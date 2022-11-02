<?php

	namespace app\models;
	use yii\db\ActiveRecord;
	class Bases extends ActiveRecord
	{
	
	public function rules(){
		return [
			[['id', 'name', 'plane', 'place'],'required']
		];
	}
	}
?>