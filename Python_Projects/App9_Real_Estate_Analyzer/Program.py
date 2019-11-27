# Remember to write this entire program by yourself. Even if you can't incorporate all the new suggestions you
# can do your best and learn new things. You can always look at the official code at the end of the project.

# Concepts to include
# 1. Dictionaries - COMPLETE
# 2. Lambdas - COMPLETE
# 3. CSV File Parsing - COMPLETE
# 4. Py2 Vs. Py3
# 5. List Comprehensions - COMPLETE
# 6. Generator expressions

import csv
import os

import time

most_expensive_house = 0
least_expensive_house = 0


def print_header():
    print('-------------------------------------------------')
    print('          APP 9: Real Estate Analyzer            ')
    print('-------------------------------------------------')

def get_data():
    base_folder = os.path.dirname(__file__)
    return os.path.join(base_folder, 'data', 'SacramentoRealEstateTransactions2008.csv')

def load_data_and_print_columns(data_file):

    with open(data_file, 'r', encoding='utf-8') as csv_file:
        reader = csv.DictReader(csv_file)

        # Print columns
        print("Headers: ", end='')
        index = 0  # Create index to use in for loop
        for column_header in reader.fieldnames:
            if index != (len(reader.fieldnames) - 1):  # For all but the last item, add a comma and a remove newline
                print(column_header + ', ', end='')
                index = index + 1
            else:
                print(column_header+'\n')  # For last item, don't add comma and add newline

        # Load data into array that is accessible once csv_file is closed
        purchases = []
        for row in reader:
            purchases.append(row)
        return purchases


def find_most_expensive_house(csv_data, predicate):
    beds = None
    baths = None
    city = None
    global most_expensive_house

    for row in csv_data:
        cost = int(row["price"])
        if predicate(cost):
            most_expensive_house = cost
            beds = int(row["beds"])
            baths = int(row["baths"])
            city = (row["city"])
            state = (row["state"])

    print(f'Most expensive house: {beds}-bed, {baths}-bath, house for ${most_expensive_house:,} in {city}, {state}\n')


def find_least_expensive_house(csv_data, predicate):
    beds = None
    baths = None
    city = None
    global least_expensive_house

    for row in csv_data:
        cost = int(row["price"])
        if predicate(cost):
            least_expensive_house = cost
            beds = int(row["beds"])
            baths = int(row["baths"])
            city = (row["city"])
            state = (row["state"])

    print(f'Least expensive house: {beds}-bed, {baths}-bath, house for ${least_expensive_house:,} in {city}, {state}\n')


def get_first_row_data(csv_data):
    first_row_data = csv_data[1].get("price")
    return int(first_row_data)


def average_house(csv_data):

    total_price = 0
    total_beds = 0
    total_baths = 0
    total_entries = 0
    two_bedroom = None

    for row in csv_data:
        total_price += int(row["price"])
        total_beds += int(row["beds"])
        total_baths += int(row["baths"])
        total_entries += 1

    for row in csv_data:
        if int(row["beds"]) == 2.0:
            two_bedroom = True
        else:
            two_bedroom = False
            break

    average_price = total_price/total_entries
    average_beds = total_beds/total_entries
    average_baths = total_baths/total_entries

    if two_bedroom:
        print(f'Average 2-bedroom house: ${average_price:,.0f}, {average_beds:.1f}-bed, {average_baths:.1f}-bath\n')
    else:
        print(f'Average house: {average_beds:.1f}-bed, {average_baths:.1f}-bath, house for ${average_price:,.0f}\n')



def average_two_bedroom_house_list(csv_data):

    two_bedroom_houses = (
        row
        for row in csv_data
        if int(row["beds"])==2
    )

    return two_bedroom_houses


def main():

    start = time.time()
    print_header()

    loaded_data = get_data()
    data = load_data_and_print_columns(loaded_data)

    global most_expensive_house
    global least_expensive_house
    least_expensive_house = get_first_row_data(data)
    find_most_expensive_house(data, lambda x: x > most_expensive_house)
    find_least_expensive_house(data, lambda x: x < least_expensive_house)
    average_house(data)
    house_list = average_two_bedroom_house_list(data)
    average_house(house_list)
    end=time.time()

    print('Execution time: {}'.format(end - start))
if __name__ == "__main__":
    main()
