# Övning

File Parties.txt innehåller:

```txt
Alice;C#;SQL
Bob;SQL
Carol;MVC;C#
```

Filen Courses.txt innehåller:

```txt
C#;2018-01-01;2018-02-05
SQL;2018-02-10;2018-03-25
MVC;2018-04-01;2018-05-15
```

Bygg en lösning där man kan välja var och en av dessa två filer och transformera innehållet i dessa till en fil med följande format:

```txt
Kursen C# pågår i 35 dagar med följande deltagare:
Alice, Carol

Kursen SQL pågår i 43 dagar med följande deltagare:
Alice, Bob

Kursen MVC pågår i 44 dagar med följande deltagare:
Carol
```

1. Unit Testing av en klass som utför transformationen

1. En Windows Forms app med användargränssnittet
