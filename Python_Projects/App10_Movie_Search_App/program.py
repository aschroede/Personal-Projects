import requests

from movie_svc import movie_svc


def print_header():
    print('---------------------------------------')
    print('       APP 10: Movie Search App        ')
    print('---------------------------------------')


def search_database():
    while True:
        string = input('Please enter text you would like to search for: ')
        if string == ('x' or 'X'):
            return
        else:
            search_result = movie_svc(string)
            for movie in search_result:
                print('{1} -- {0}'.format(movie.title, movie.year))


def main():
    print_header()
    search_database()


if __name__ == '__main__':
    main()
