import requests
import bs4
import collections

WeatherReport = collections.namedtuple('WeatherReport', 'cond, temp, scale, loc')

def main():
    print_header()

    city_name = input("Please enter a city you want the weather for: ")
    city_name = city_name.lower().strip()
    html = get_html_from_the_web(city_name)

    report = get_weather_from_html(html)
    print('The temperature in {} is {} and {} {}'.format(report.loc, report.cond, report.temp, report.scale))


def print_header():
    print('---------------------------')
    print('        WEATHER APP')
    print('---------------------------')


def get_html_from_the_web(zipcode):
    url = 'https://www.wunderground.com/weather-forecast/{}'.format(zipcode)
    response = requests.get(url)
    print(url)
    return response.text


def get_weather_from_html(html):
    soup = bs4.BeautifulSoup(html, 'html.parser')
    loc = soup.find(class_='region-content-header').find('h1').get_text().strip()
    condition = soup.find(class_='condition-icon').get_text().strip()
    temp = soup.find(class_='wu-unit-temperature').find(class_='wu-value').get_text().strip()
    scale = soup.find(class_='wu-unit-temperature').find(class_='wu-label').get_text().strip()
    #return  condition, temp, scale, loc
    report = WeatherReport(cond=condition, temp=temp, scale=scale, loc=loc)
    return report
if __name__ == '__main__':
    main()



