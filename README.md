# XML to Map

*Copy of the tech test requirements is included [here](https://github.com/lornasw93/api-the-musicial-kind/blob/master/Interact%20with%20APIs.pdf)*

## If I had more time I would have... ⏳
* Added file uploader (for XML file)
* Improved the look and feel
* More visual loading
* Better error handling
* Async functions

## However, I have... ✅
* Integrated with Google Maps API
* Used marker clusters
* Used VueJS
* Used very basic Bootstrap

## Quick Start 

Make sure you replace the **APIKEY** value with your Google Maps API Key in the Layout.cshtml file:
```
<script src="https://maps.googleapis.com/maps/api/js?key=APIKEY"></script>
```

If wanting to run locally, download the repo, restore Nuget packages and run.

## Notes
In a previous role I worked on a project called "My Surgery Website" which is like Wordpress i.e. drag and drop, but from built scratch. It's used to provide websites for GP surgeries around the UK - in fact over half. I built [this map](https://www.mysurgerywebsite.co.uk/live/contact-us/) where it pin points all the locations of surgeries using it. To also note that the locations were retrieved from a SQL database where the data wasn't consistent i.e. had a mix of postcodes and lat/long.

After I left that role, I created a side project where instead of getting results from a SQL database would be from 2 files where 1 contained postcodes and the other lat/long. The aim of that project was to extract data from both files into a new JSON file. I was able to convert the postcodes by using an existing package. 

[Check out the code here](https://github.com/lornasw93/csv-to-map/blob/master/CsvToMap/Controllers/Api/FileController.cs)


