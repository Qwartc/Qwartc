<?php

/* @var $this yii\web\View */
use yii\helpers\Html;
use yii\widgets\LinkPager;
use app\models\Users;


$this->title = 'My Yii Application';
?>
<div class="site-index">
	<ol>
		<li><? echo Html::a('Сделанные поля', '?r=table%2Ffields_done')?></li>
		<li><? echo Html::a('События', '?r=table%2Faction')?></li>
		<li><? echo Html::a('Топливо', '?r=table%2Ffuel')?></li>
		<li><? echo Html::a('Топливо на базе', '?r=table%2Ffuel_on_base')?></li>
	</ol>
    
</div>
