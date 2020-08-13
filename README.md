# XML to Map

*Copy of the tech test requirements is included [here](https://github.com/lornasw93/xml-to-map/blob/master/Tech%20Test.docx)* (with the API Key hidden)

![](https://github.com/lornasw93/xml-to-map/blob/master/xml-to-map.gif)

## If I had more time I would have... ⏳
* Deployed via Azure
* Added file uploader (for XML file)
* Improved the look and feel
* More visual loading
* Error handling
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

For now, I've put the *Locations.xml* file on my local drive in a folder called *XmlToMap*, this will need changing if you're going to run it (*MapController*):
```
var directory = new DirectoryInfo("C:\\Users\\lornn\\Documents\\XmlToMap");
```

If wanting to run locally, download the repo, restore Nuget packages and run.

## Notes
In a previous role I worked on a project called "My Surgery Website" which is like Wordpress i.e. drag and drop, but from built scratch. It's used to provide websites for GP surgeries around the UK - in fact over half. I built [this map](https://www.mysurgerywebsite.co.uk/live/contact-us/) where it pin points all the locations of surgeries using it. To also note that the locations were retrieved from a SQL database where the data wasn't consistent i.e. had a mix of postcodes and lat/long.

After I left that role, I created a side project where instead of getting results from a SQL database would be from 2 files where 1 contained postcodes and the other lat/long. The aim of that project was to extract data from both files into a new JSON file. I was able to convert the postcodes by using an existing package. 

[Check out the code here](https://github.com/lornasw93/csv-to-map/blob/master/CsvToMap/Controllers/Api/FileController.cs)


