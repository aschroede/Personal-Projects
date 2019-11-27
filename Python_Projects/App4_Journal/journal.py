import os


def load(journal_name):

    """
    Method for loading a journal data structure.
    :param journal_name: Name of the journal to be loaded.
    :return: Journal data structure populated with the stored file data.
    """
    data = []
    filename = get_full_pathname(journal_name)

    if os.path.exists(filename):
        with open(filename) as fin:
            for entry in fin.readlines():
                data.append(entry.rstrip())

    return data


def save(journal_name, journal_data):

    filename = get_full_pathname(journal_name)
    print('...saving to {}' .format(filename))

    with open(filename, 'w') as fout:
        for entry in journal_data:
            fout.write(entry + '\n')


def get_full_pathname(journal_name):
    filename = os.path.abspath(os.path.join('.', 'journals', journal_name + '.jrl'))
    return filename


def add_entry(journal_name, journal_data):
    journal_name.append(journal_data)

