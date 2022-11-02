<?php

	namespace app\models;
	use yii\db\ActiveRecord;
	class Type extends ActiveRecord
	{
		public function rules(){
		return [
			[['name'],'required']
		];
	}
	}
?>