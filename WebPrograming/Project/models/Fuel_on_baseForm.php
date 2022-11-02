<?php
	namespace app\models;
	use yii\db\ActiveRecord;
class Fuel_on_baseForm extends ActiveRecord
	{
		/*public $type;
		public $base;
		public $comment;
		public $amount;*/

		public function rules()
		{
			return [
				[['amount', 'base'], 'required', 'message' => 'Поле должно быть заполнено']
			];
		}
		public static function tableName()
    	{
        	return 'fuel_on_base';
    	}
	}
?>