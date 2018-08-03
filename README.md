# MyComparer (C#)

This project was created to identify and remove duplicated files in large quantity, under unstable connection and in the messiest organizations scenarios as possible.

After some years and a lot of unduly backups I end up with 8 Terabyte of duplicates files in many external HD and a lot of scenarios (corrupted data, duplicated full and incremental files, removed, moved, etc.).

There were almost 400,000 folder and more than 2,000,000 files. To help to go through directory tree as faster as possible, which could be done in parallel, the project List was created.

4 elements (A, B, C, D) results in 6 comparations (AB, AC, AD, BC, BD, CD)
Cn,p =      n!
          p! (n – p)!
n-> number of item (4)
p-> items in comparation (2)

2 million of files results in (sorry, the number was too big to be calculate but, to have an idea, 2,000 results in 2 trillion of comparations (1,999,999))

To handle 8 terabytes can take a lot of time, produces many memory exceptions and, in case you bumped the USB cable or need to give a break, restart the process many times. Therefore, a persistence layer was created [MyList1.DAL](https://github.com/vinils/MyList1.DAL) to store the data in memory or in the SQL and MD5 hash ([MyComparer1.Hashers.MD5s](https://github.com/vinils/MyComparer1.Hashers.MD5s)) was used to generate hashes and uncoupled comparer with any other set of data easier at any time.

To able other hashers comparations, [MyComparer1.Hashers](https://github.com/vinils/MyComparer1.Hashers) layer was created to uncouple that.

To able other types of comparation, Interface o Equality compare standard was used.
