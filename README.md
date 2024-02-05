
*)=> NOTE: I`m using Altair UI, so once you run the application you need to change the route from "/swagger/index.html" to be "/ui/altair".
<-----------------------------------------------------------------------------------------------------------------------------------------------------------------<

*)=> Needed Json format to retrieve excpected data - add it into altair ui left window and then you can choos Post Or Get verb (You can remove or add the property as you want to retrieve it by the json):-

{
  authors {
    id
    name
    age
    nationality
    isDeleted
    createdOn
    modifiedOn
    books {
      id
      name
      description
      price
      currency
      publishDate
      authorId
      isDeleted
      createdOn
      modifiedOn
    }
  }
}

<-----------------------------------------------------------------------------------------------------------------------------------------------------------------<
*)=> Don`t forget to add your conn string and excecute update-database command to reflect the entities in you Database.
