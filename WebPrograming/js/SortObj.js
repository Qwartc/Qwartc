clients = [
         2,
         {
            name : "Petro",
            type : "usual",
            date : "16.03.1970"   
         },
         {
            name : "Nikita",
            type : "usual",
            date : "16.03.1985"   
         },
         {
            name : 'Max',
            type : "vip",
            date : "17.06.1985"   
         },
         {
            name : 'Victor',
            type : "vip",
            date : "17.06.1984"   
         },
         {
            name : "Denis",
            type : "gold",
            date : "16.02.1995"   
         },
         {
            name : "Alex",
            type : "gold",
            date : "16.02.1996"   
         },
         {
            name : "Oleh",
            date : "16.02.1996"   
         },
         {
            name : "Gleb",
            type : "usual",  
         },
         "test",
         
    ];
    function getage(date)
    {
        var now = new Date();
        var today = new Date(now.getFullYear(), now.getMonth(), now.getDate());
        var birthday = date.split(".")
        var dob = new Date(birthday[2], birthday[1], birthday[0]);
        var dobnow = new Date(today.getFullYear(), dob.getMonth(), dob.getDate());
        var age;

        age = today.getFullYear() - dob.getFullYear();

        if (today < dobnow) {
          age = age-1;
        }
        return age;
    }
    function getSortArray(arr){
        types = ["usual", "gold", "vip"];
        let result = new Array();
        arr = arr.filter(data => typeof data === "object" && data.date != undefined && data.type != undefined);
        for (let i = 0, endI = arr.length - 1; i < endI; i++)
        {
            let wasSwap = false;
            for (let j = 0, endJ = endI - i; j < endJ; j++) {
                if (getage(arr[j].date) > getage(arr[j + 1].date)) {
                    [arr[j], arr[j + 1]] = [arr[j + 1], arr[j]];
                    wasSwap = true;
                }
            }
            if (!wasSwap) break;
        }
        for(type of types)
        {
            for (item of arr)
            {
                if(item.type === type)
                {
                    result.push(item);
                    delete item.name;
                }
            }
        }
        return result;
    }
    result = getSortArray(clients);
    for(item of result)
    {
       document.write("<p><strong>type: </strong>"+item.type+"&nbsp&nbsp&nbsp"+"<strong>date: </strong>"+item.date+"</p>"); 
    }
    console.log(result);