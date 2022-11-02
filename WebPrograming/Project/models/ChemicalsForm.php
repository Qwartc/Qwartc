<?php
	namespace app\models;
	use yii\db\ActiveRecord;
class ChemicalsForm extends ActiveRecord
	{
		/*public $type;
		public $base;
		public $comment;
		public $amount;*/

		public function rules()
		{
			return [
				[['name', 'amount', 'base'], 'required', 'message' => 'Поле должно быть заполнено']
			];
		}
		public static function tableName()
    	{
        	return 'chemicals';
    	}
	}
?>