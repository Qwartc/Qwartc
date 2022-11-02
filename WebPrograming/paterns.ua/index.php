<?php

use Stichoza\GoogleTranslate\GoogleTranslate;

$tr = new GoogleTranslate(); // Translates to 'en' from auto-detected language by default
$tr->setSource('en'); // Translate from English
$tr->setSource(); // Detect language automatically
$tr->setTarget('ua'); // Translate to Urkaine


echo $tr->translate('Hello World!');
?>