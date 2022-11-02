<?php

	namespace app\models;
	use yii\db\ActiveRecord;
	class Fuel_on_base extends ActiveRecord
	{
		public function rules(){
		return [
			[['amount', 'base'],'required']
		];
	}
	
	}
?>