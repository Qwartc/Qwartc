<?php

	namespace app\models;
	use yii\db\ActiveRecord;
	class Fuel extends ActiveRecord
	{
		public function rules(){
		return [
			[['id', 'amount', 'technic', 'time', 'base'],'required']
		];
	}
	
	}
?>