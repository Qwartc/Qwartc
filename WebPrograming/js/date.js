function monthDays(year, month) 
		{
    		return (month == 2 ? 
               ((year % 4 != 0 || 
                 (year % 100 == 0 && year % 400 != 0)) ? 28 : 29) : 
               (((month < 8 && (month & 1) == 0) ||
                 (month > 7 && (month & 1) == 1)) ? 31 : 30));
		}

		function dateDiff(date1, date2) {
		    
		    years = date2.getUTCFullYear()-(y1 = date1.getUTCFullYear());
		    months = date2.getUTCMonth()-(m1 = date1.getUTCMonth());
		    years_and_month = Date.parse(years) + Date.parse(months);
		    days = (d2 = date2.getUTCDate())-(d1 = date1.getUTCDate());
		    hours = date2.getUTCHours()-date1.getUTCHours();
		    minutes = date2.getUTCMinutes()-date1.getUTCMinutes();
		    seconds = date2.getUTCSeconds()-date1.getUTCSeconds();
		    dd = 0;
		    if (seconds < 0) {
		        seconds += 60;
		        minutes--;
		    }
		    if (minutes < 0) {
		        minutes += 60;
		        hours--;
		    }
		    if (hours < 0) {
		        hours += 24;
		        days--;
		        dd = 1;
		    }
		    if (days < 0) {
		        days = monthDays(y1, m1)-d1+d2-dd;
		        months--;
		    }
		    if (months < 0) {
		        months += 12;
		        years--;
		    }
		    return {years: years, months: months, days: days,
		            hours: hours, minutes: minutes, seconds: seconds};
		}

		var d1 = new Date("2/24/2022 05:00:00");
		var d2 = new Date();
		var diff = dateDiff(d1, d2);
		document.write(diff.years+' лет, '+
		      diff.months+' месяцев, '+
		      diff.days+' дней, '+
		      diff.hours+' часов, '+
		      diff.minutes+' минут, '+
		      diff.seconds+' секунд');
		console.log(diff.years+' лет, '+
		      diff.months+' месяцев, '+
		      diff.days+' дней, '+
		      diff.hours+' часов, '+
		      diff.minutes+' минут, '+
		      diff.seconds+' секунд');