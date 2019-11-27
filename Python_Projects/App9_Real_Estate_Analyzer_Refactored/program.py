import csv
import os
import statistics

from data_class import Purchase


def print_header():
    print('-------------------------------------')
    print('   Real Estate Analyzer Refactored   ')
    print('-------------------------------------')


def get_data_file():
    base_directory = os.path.dirname(__file__)
    data_file = os.path.join(base_directory, 'data', 'SacramentoRealEstateTransactions2008.csv')
    return data_file


def load_data(filename):
    with open(filename, 'r', encoding='utf-8') as data:

        reader = csv.DictReader(data)
        housing_data= []
        for row in reader:
            purchase = Purchase.create_from_dict(row)
            housing_data.append(purchase)
        print(housing_data[0].__dict__)
    return housing_data



def query_data(data):

    data.sort(key=lambda p: p.price)
    most_expensive_house = data[-1]
    print('Most expensive house: ${:,}'.format(int(most_expensive_house.price)))
    least_expensive_house = data[0]
    print('Least expensive house: ${:,}'.format(int(least_expensive_house.price)))


    prices = [
        p.price
        for p in data
    ]

    avg_price = statistics.mean(prices)
    print('The average price is: ${:,}'.format(int(avg_price)))

    two_bedroom_prices = [
        p
        for p in data
        if p.beds == 2
    ]

    avg_two_bedroom_prices = statistics.mean(p.price for p in two_bedroom_prices)
    avg_two_bedroom_baths = int(statistics.mean(p.baths for p in two_bedroom_prices))
    avg_two_bedroom_beds = (statistics.mean(p.beds for p in two_bedroom_prices))

    print('Average two bedroom house: ${:,}, {}-baths, {}-beds.'.format(int(avg_two_bedroom_prices),
                                                                        avg_two_bedroom_baths, avg_two_bedroom_beds))



def main():
    print_header()
    filename = get_data_file()
    data = load_data(filename)
    query_data(data)


if __name__ == '__main__':
    main()