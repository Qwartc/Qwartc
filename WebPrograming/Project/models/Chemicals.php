<?php

	namespace app\models;
	use yii\db\ActiveRecord;
	class Chemicals extends ActiveRecord
	{
		public function rules(){
		return [
			[['id', 'name', 'amount', 'base'],'required']
		];
	}
	
	}
?>