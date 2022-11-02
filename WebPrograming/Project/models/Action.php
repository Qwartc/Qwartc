<?php

	namespace app\models;
	use yii\db\ActiveRecord;
	class Action extends ActiveRecord
	{
	
	
	
	public function rules(){
		return [
			[['id', 'time', 'type', 'base', 'amount', 'comment', 'user'],'required']
		];
	}
	}
?>