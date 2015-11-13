/*var XmlHttpObj_2;
var mycity;
function CreateXmlHttpObj( ){
    try{
        XmlHttpObj_2 = new ActiveXObject("Msxml2.XMLHTTP");
    }
    catch( e ){
        try{
            XmlHttpObj_2 = new ActiveXObject("Microsoft.XMLHTTP");
        } 
        catch( oc ){
            XmlHttpObj_2 = null;
        }
    }
    if(!XmlHttpObj_2 && typeof XMLHttpRequest != "undefined"){
    XmlHttpObj_2 = new XMLHttpRequest();
    }
}

function show_cities(id, city){
    var requestUrl;
    mycity=city;
    requestUrl = "http://partner.city-discovery.com/globals/script/showCities.php?id=" + encodeURIComponent(id);
    CreateXmlHttpObj();

    if(XmlHttpObj_2){
        XmlHttpObj_2.onreadystatechange = process_cities;
        XmlHttpObj_2.open("GET", requestUrl, true);
        XmlHttpObj_2.send( null );
    }
}

function process_cities(){
    document.frm_marketing.cities.options[0] = new Option('Loading please wait...','');
    if( XmlHttpObj_2.readyState == 1 ){
        document.getElementById('cities').innerHTML = "<option>Loading please wait...</option>";
    }

    if( XmlHttpObj_2.readyState == 4 ){
        if( XmlHttpObj_2.status == 200 ){            
            populate_cities(XmlHttpObj_2.responseXML.documentElement);
        }else{
            alert("problem retrieving data from the server, status code: "  + XmlHttpObj_2.status);
        }
    }
}

function populate_cities( countryNode ){
    var target_id = document.getElementById("cities");

    for( var count = target_id.options.length-1; count >-1; count-- ){
        target_id.options[count] = null;
    }

    var countryNodes = countryNode.getElementsByTagName('city_xml');
    var idValue;
    var textValue;
    var optionItem;

    for( var count = 0; count < countryNodes.length; count++ ){
        textValue = GetInnerText_region(countryNodes[count]);
        idValue = countryNodes[count].getAttribute("id");
        //optionItem = new Option( textValue,idValue,false,false );
        //alert(textValue.toLowerCase()+"=="+mycity.toLowerCase());
        if(textValue.toLowerCase()==mycity.toLowerCase()){
            optionItem = new Option( textValue,idValue,true);
        }else{
            optionItem = new Option( textValue,idValue,false);
        }
        target_id.options[target_id.length] = optionItem;
    }
}*/

function show_cities_selected(id, city){
    var requestUrl;
    mycity=city;
    requestUrl = "http://attractions.bravofly.com/globals/script/showCities.php?id=" + encodeURIComponent(id);
    CreateXmlHttpObj();
    
    if(XmlHttpObj_2){
        XmlHttpObj_2.onreadystatechange = process_cities;
        XmlHttpObj_2.open("GET", requestUrl, true);
        XmlHttpObj_2.send( null );
    }
}

    function isDefined(variable){
        return (!(!( variable||false )))
    }
    
    
	function show_cities_activity(id, lang){
		var requestUrl;
        if(document.location.protocol=="https:"){
            var targetFile = "https://attractions.bravofly.com/cc_getCities.php";
        }else{
            var targetFile = "http://attractions.bravofly.com/cc_getCities.php";
        }
		
        
		requestUrl = targetFile + "?id=" + encodeURIComponent(id);
        if(isDefined(lang)){
            requestUrl += "&lang="+lang;
        }
		CreateXmlHttpObj();
	
		if(XmlHttpObj_2){
			XmlHttpObj_2.onreadystatechange = process_cities_activity;
			XmlHttpObj_2.open("GET", requestUrl, true);
			XmlHttpObj_2.send( null );
		}
	}
	
	function process_cities_activity( ){
		document.getElementById('activity_city').options[0] = new Option('Loading please wait...','');
		if( XmlHttpObj_2.readyState == 1 ){
			document.getElementById('activity_city').innerHTML = "<option>Loading please wait...</option>";
		}
	
		if( XmlHttpObj_2.readyState == 4 ){
			if( XmlHttpObj_2.status == 200 ){			
				populate_cities_activity( XmlHttpObj_2.responseXML.documentElement );
			}else{
				alert("problem retrieving data from the server, status code: "  + XmlHttpObj_2.status);
			}
		}
	}
	
	function populate_cities_activity( countryNode ){
		var target_id = document.getElementById("activity_city");
	
		for( var count = target_id.options.length-1; count >-1; count-- ){
			target_id.options[count] = null;
		}
	
		var countryNodes = countryNode.getElementsByTagName('city_xml');
		var idValue;
		var textValue;
		var optionItem;
	
		for( var count = 0; count < countryNodes.length; count++ ){
			textValue = GetInnerText_region(countryNodes[count]);
			idValue = countryNodes[count].getAttribute("id");
			optionItem = new Option( textValue,idValue,false,false );
			target_id.options[target_id.length] = optionItem;
		}
	}
	
	
	/* SELECT THEME */
	
	function cc_getThemes(id, lang){
        var requestUrl;
        if(document.location.protocol=="https:"){
            var targetFile = "https://attractions.bravofly.com/cc_getThemes.php";
        }else{
            var targetFile = "http://attractions.bravofly.com/cc_getThemes.php";
        }
		
		requestUrl = targetFile + "?id=" + encodeURIComponent(id);
        if(isDefined(lang)){
            requestUrl += "&lang="+lang;
        }

		CreateXmlHttpObj();
	
		if(XmlHttpObj_2){
			XmlHttpObj_2.onreadystatechange = process_themes_activity;
			XmlHttpObj_2.open("GET", requestUrl, true);
			XmlHttpObj_2.send( null );
		}
	}
	
	function process_themes_activity()
	{
		document.getElementById('activity_category').options[0] = new Option('Loading please wait...','');
		if( XmlHttpObj_2.readyState == 1 ){
			document.getElementById('activity_category').innerHTML = "<option>Loading please wait...</option>";
		}
	
		if( XmlHttpObj_2.readyState == 4 ){
			if( XmlHttpObj_2.status == 200 ){			
				populate_themes_activity( XmlHttpObj_2.responseXML.documentElement );
			}else{
				alert("problem retrieving data from the server, status code: "  + XmlHttpObj_2.status);
			}
		}
	}
	
	function populate_themes_activity(countryNode)
	{
		var target_id = document.getElementById("activity_category");
	
		for( var count = target_id.options.length-1; count >-1; count-- ){
			target_id.options[count] = null;
		}
	
		var countryNodes = countryNode.getElementsByTagName('city_xml');
		var idValue;
		var textValue;
		var optionItem;
	
		for( var count = 0; count < countryNodes.length; count++ ){
			textValue = GetInnerText_region(countryNodes[count]);
			idValue = countryNodes[count].getAttribute("id");
			optionItem = new Option( textValue,idValue,false,false );
			target_id.options[target_id.length] = optionItem;
		}
	}
	/* END SELECT THEME */

    

    function show_cities_activity_box(id, lang){
        var requestUrl;
        if(document.location.protocol=="https:"){
            var targetFile = "https://attractions.bravofly.com/cc_getCities.php";
        }else{
            var targetFile = "http://attractions.bravofly.com/cc_getCities.php";
        }
        
        
        requestUrl = targetFile + "?id=" + encodeURIComponent(id);
        if(isDefined(lang)){
            requestUrl += "&lang="+lang;
        }
        CreateXmlHttpObj();
    
        if(XmlHttpObj_2){
            XmlHttpObj_2.onreadystatechange = process_cities_activity_box;
            XmlHttpObj_2.open("GET", requestUrl, true);
            XmlHttpObj_2.send( null );
        }
    }
    
    function process_cities_activity_box( ){
        document.getElementById('activity_city_box').options[0] = new Option('Loading please wait...','');
        if( XmlHttpObj_2.readyState == 1 ){
            document.getElementById('activity_city_box').innerHTML = "<option>Loading please wait...</option>";
        }
    
        if( XmlHttpObj_2.readyState == 4 ){
            if( XmlHttpObj_2.status == 200 ){            
                populate_cities_activity_box( XmlHttpObj_2.responseXML.documentElement );
            }else{
                alert("problem retrieving data from the server, status code: "  + XmlHttpObj_2.status);
            }
        }
    }
    
    function populate_cities_activity_box( countryNode ){
        var target_id = document.getElementById("activity_city_box");
    
        for( var count = target_id.options.length-1; count >-1; count-- ){
            target_id.options[count] = null;
        }
    
        var countryNodes = countryNode.getElementsByTagName('city_xml');
        var idValue;
        var textValue;
        var optionItem;
    
        for( var count = 0; count < countryNodes.length; count++ ){
            textValue = GetInnerText_region(countryNodes[count]);
            idValue = countryNodes[count].getAttribute("id");
            optionItem = new Option( textValue,idValue,false,false );
            target_id.options[target_id.length] = optionItem;
        }
    }
    
    
    /* SELECT THEME */
    
    function cc_getThemes_box(id, lang){
        var requestUrl;
        if(document.location.protocol=="https:"){
            var targetFile = "https://attractions.bravofly.com/cc_getThemes.php";
        }else{
            var targetFile = "http://attractions.bravofly.com/cc_getThemes.php";
        }
        
        requestUrl = targetFile + "?id=" + encodeURIComponent(id);
        if(isDefined(lang)){
            requestUrl += "&lang="+lang;
        }

        CreateXmlHttpObj();
    
        if(XmlHttpObj_2){
            XmlHttpObj_2.onreadystatechange = process_themes_activity_box;
            XmlHttpObj_2.open("GET", requestUrl, true);
            XmlHttpObj_2.send( null );
        }
    }
    
    function process_themes_activity_box()
    {
        document.getElementById('activity_category_box').options[0] = new Option('Loading please wait...','');
        if( XmlHttpObj_2.readyState == 1 ){
            document.getElementById('activity_category_box').innerHTML = "<option>Loading please wait...</option>";
        }
    
        if( XmlHttpObj_2.readyState == 4 ){
            if( XmlHttpObj_2.status == 200 ){            
                populate_themes_activity_box( XmlHttpObj_2.responseXML.documentElement );
            }else{
                alert("problem retrieving data from the server, status code: "  + XmlHttpObj_2.status);
            }
        }
    }
    
    function populate_themes_activity_box(countryNode)
    {
        var target_id = document.getElementById("activity_category_box");
    
        for( var count = target_id.options.length-1; count >-1; count-- ){
            target_id.options[count] = null;
        }
    
        var countryNodes = countryNode.getElementsByTagName('city_xml');
        var idValue;
        var textValue;
        var optionItem;
    
        for( var count = 0; count < countryNodes.length; count++ ){
            textValue = GetInnerText_region(countryNodes[count]);
            idValue = countryNodes[count].getAttribute("id");
            optionItem = new Option( textValue,idValue,false,false );
            target_id.options[target_id.length] = optionItem;
        }
    }
    /* END SELECT THEME */    

    /*for transfer*/
    function show_transfer_cities(id, lang){
        var requestUrl;
        if(document.location.protocol=="https:"){
            var targetFile = "https://attractions.bravofly.com/globals/script/showCities_transfer.php";
        }else{
            var targetFile = "http://attractions.bravofly.com/globals/script/showCities_transfer.php";
        }
        
        
        requestUrl = targetFile + "?id=" + encodeURIComponent(id);
        if(isDefined(lang)){
            requestUrl += "&lang="+lang;
        }
        CreateXmlHttpObj();
    
        if(XmlHttpObj_2){
            XmlHttpObj_2.onreadystatechange = process_cities_transfer_activity_box;
            XmlHttpObj_2.open("GET", requestUrl, true);
            XmlHttpObj_2.send( null );
        }
    }
    function process_cities_transfer_activity_box( ){
        document.getElementById('air_city_box').options[0] = new Option('Loading please wait...','');
        if( XmlHttpObj_2.readyState == 1 ){
            document.getElementById('air_city_box').innerHTML = "<option>Loading please wait...</option>";
        }
    
        if( XmlHttpObj_2.readyState == 4 ){
            if( XmlHttpObj_2.status == 200 ){            
                populate_cities_transfer_activity_box( XmlHttpObj_2.responseXML.documentElement );
            }else{
                alert("problem retrieving data from the server, status code: "  + XmlHttpObj_2.status);
            }
        }
    }
    
    function populate_cities_transfer_activity_box( countryNode ){
        var target_id = document.getElementById("air_city_box");
    
        for( var count = target_id.options.length-1; count >-1; count-- ){
            target_id.options[count] = null;
        }
    
        var countryNodes = countryNode.getElementsByTagName('city_xml');
        var idValue;
        var textValue;
        var optionItem;
    
        for( var count = 0; count < countryNodes.length; count++ ){
            textValue = GetInnerText_region(countryNodes[count]);
            idValue = countryNodes[count].getAttribute("id");
            optionItem = new Option( textValue,idValue,false,false );
            target_id.options[target_id.length] = optionItem;
        }
    }        
    
/*function GetInnerText_region( node ){
     return( node.textContent || node.innerText || node.text );
}*/

if(typeof GetInnerText_region == 'function'){

}else{
    function GetInnerText_region( node ){
         return( node.textContent || node.innerText || node.text );
    }
}

if(typeof validate_findThings == 'function'){

}else{
    function validate_findThings(){
        var frm = document.findthings_frm;
        //if(frm.country_searchBox.value=="")
        if(frm.country_searchBox.selectedIndex==0)
        {
            alert("Please select a country");
            frm.country_searchBox.focus();
        }else if(frm.city_searchBox.selectedIndex==0){
            alert("Please select a city");
            frm.city_searchBox.focus();
        
        }else{
            frm.submit();    
        }
    }
}

