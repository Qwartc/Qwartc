<?php

	namespace app\models;
	use yii\db\ActiveRecord;
	class Fields extends ActiveRecord
	{
		public function rules(){
		return [
			[['id', 'number_field', 'base', 'place', 'plane', 'plant'],'required']
		];
	}
	}
?>