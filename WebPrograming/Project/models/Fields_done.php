<?php

	namespace app\models;
	use yii\db\ActiveRecord;
	class Fields_done extends ActiveRecord
	{
		public function rules(){
		return [
			[['id', 'field_number', 'base', 'amount', 'who', 'field', 'type', 'technic', 'date'],'required']
		];
	}
	}
	
?>