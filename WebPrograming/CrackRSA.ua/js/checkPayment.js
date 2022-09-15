request_obj = {
			card_sender : "4111111111100056",
			card_recipient : "5486732058864471",
			sum : 23,
			currency : "UAH"
		};
		
		function checkCard(card)
		{
		  var mastercard = /^(?:5[1-5][0-9]{14})$/;
		  var visa = /^(?:4[0-9]{12}(?:[0-9]{3})?)$/;

		  if(card.match(mastercard) || card.match(visa))
		    {
		    	return true;
		    }
		    else
		    {
		    	return false;
		    }
		}
		function checkSum(sum)
		{
			return sum != null && sum != undefined && sum > 0;
		}
		function checkCurrency(currency)
		{
			return currency.toLowerCase() === "uah" || currency.toLowerCase() === "usd" || currency.toLowerCase() === 'eur';
		}
		function checkPayment(arr)
		{
			result = {
				result : true,
				description : ""
			};
			if(!checkCard(arr.card_sender))
			{
				result.result = false;
				result.description += "Invalid card sender.";
			}
			if(!checkCard(arr.card_recipient))
			{
				result.result = false;
				result.description += "Invalid card recipient.";
			}
			if(!checkSum(arr.sum))
			{
				result.result = false;
				result.description += "Invallid sum.";
			}
			if (!checkCurrency(arr.currency))
			{
				result.result = false;
				result.description += "Invallid currency.";

			}
			return result;
		}
		result = checkPayment(request_obj);
		document.write("<p>"+"Result: "+result.result+" Description: "+result.result+"</p>");
		console.log(checkPayment(request_obj));