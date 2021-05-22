curl -X GET "https://localhost:44310/Person/Doctors" -H  "accept: text/plain"
curl -X POST "https://localhost:44310/Person/AddDoctor?Id=11&Name=Mariusz&Surname=Mariuszewski&Specialization=laryngolog&Height=1.8&Gender=Male" -H  "accept: text/plain" -d ""
curl -X GET "https://localhost:44310/Person/Patients" -H  "accept: text/plain"
curl -X GET "https://localhost:44310/Person/Doctors-Id?id=11" -H  "accept: text/plain"


pause