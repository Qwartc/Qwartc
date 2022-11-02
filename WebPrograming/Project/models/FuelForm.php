<?php
	namespace app\models;
	use yii\db\ActiveRecord;
class FuelForm extends ActiveRecord
	{
		/*public $type;
		public $base;
		public $comment;
		public $amount;*/

		public function rules()
		{
			return [
				[['amount', 'technic', 'time', 'base'], 'required', 'message' => 'Поле должно быть заполнено']
			];
		}
		public static function tableName()
    	{
        	return 'fuel';
    	}
	}
?>