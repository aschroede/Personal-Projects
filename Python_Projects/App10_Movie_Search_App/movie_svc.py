import requests
import collections

def movie_svc(search_term):

    if not search_term or not search_term.strip:
        raise ValueError("Search text is required.")

    try:
        MovieResult = collections.namedtuple('MovieResult', 'imdb_code,title,duration,director,year,rating,imdb_score,keywords,genres') # Create a namedtuple to store movie data in.
        # Data is easier to access than just working with the list that MovieData-get('hits') returns. Fields of namedtuples can be accessed by key or by index.

        url = 'http://movie_service.talkpython.fm/api/search/{}'.format(search_term)
        resp = requests.get(url)
        MovieData = resp.json()     # Converts request response into a dictionary
        MovieList = MovieData.get('hits') # Returns a list of dictionaries of movies that match the string to be searched

        movies = [
            MovieResult(**movie)
            for movie in MovieList
        ]
        movies.sort(key=lambda m: m.year , reverse=True)
        return movies

    except requests.exceptions.ConnectionError:
        print('Error: your network is down.')
    except:
        print('That didn\'t work!')



