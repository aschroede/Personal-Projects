# App8: File Searcher App
# Author: Andrew Schroeder

import os.path
import time
from os.path import join


def print_header(file_output):
    print('---------------------------------')
    print('       App 8: File Searcher')
    print('---------------------------------')
    print_to_file(file_output, '---------------------------------\n')
    print_to_file(file_output, '       App 8: File Searcher\n')
    print_to_file(file_output, '---------------------------------\n')


def get_directory_from_user():
    while True:
        directory = input("Which directory would you like to search? ")
        dir_path = os.path.abspath(directory)
        if os.path.exists(dir_path):
            break
        elif directory == 'e':
            exit()
        else:
            print('Sorry, that is not a valid path. Please try again.\n')
    return dir_path


def get_string_from_user():
    string = input("What string would you like to search for? ")
    return string


def file_name():
    string = input("File name for storing search results? ")
    return string


def search_directory_for_string(file_path, string, file_output):
    print("Searching {} for '{}'".format(file_path, string))
    print_to_file(file_output, "Searching {} for '{}'\n\n".format(file_path, string))

    for file in os.listdir(file_path):  # Cycle through each file and search it for the string.
        filename = os.path.join(file_path, file)  # Get full path for each file or directory.

        if os.path.isfile(filename):  # Only run this code if file_path points to a file rather than a directory.
            line_num = 0
            file_instance_num = 0

            print('Reading file: {}\n\n'.format(filename))
            print_to_file(file_output, 'Reading file: {}\n\n'.format(filename))

            with open(filename, 'r', encoding='utf-8') as fin:  # Open each file in the provided directory.

                while True:
                    fin_line_by_line = fin.readline()  # Read each line of the text one by one.
                    line_num += 1
                    if string in fin_line_by_line:  # If the string has been found in the current line, step into.
                        file_instance_num += 1
                        yield fin_line_by_line, line_num  # yield the current line number and line content where the string has been found.
                    elif fin_line_by_line == '':  # If the end of the file has been reached, break.
                        print('Total instances found in {}: {}\n\n'.format(file,
                                                                           file_instance_num))  # Print number of string instances in each file.
                        print_to_file(file_output, 'Total instances found in {}: {}\n\n'.format(file, file_instance_num))  # Print number of string instances in each file.
                        break

        elif os.path.isdir(filename):  # Run this code if file_path points to a directory.
            yield from search_directory_for_string(filename, string,
                                                   file_output)  # If you just call your generator function
            # recursively without looping over it or yield
            # from-ing it, all you do is build a new generator,
            # without actually running the function body or yielding anything.



def print_to_file(file, string):
    file.write(string)


def main():
    output_file = file_name()
    search_results = open(output_file, "w+")

    print_header(search_results)

    dir_path = get_directory_from_user()
    string = get_string_from_user()

    start = time.time()

    my_search = search_directory_for_string(dir_path, string, search_results)
    for line, line_num in my_search:
        print_to_file(search_results, 'On line {}: {}\n'.format(line_num, line))

    end = time.time()

    print('Execution time: {}'.format(end - start))
    print_to_file(search_results, 'Execution time: {}'.format(end - start))

    search_results.close()


if __name__ == "__main__":
    main()
