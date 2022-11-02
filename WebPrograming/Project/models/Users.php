<?php

	namespace app\models;
	use Yii;
	use yii\db\ActiveRecord;
	class Users extends \yii\db\ActiveRecord
	{
		public static function tableName()
		{
			return 'users';
		}
	}
?>