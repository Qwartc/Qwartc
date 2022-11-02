<?php
	namespace app\models;
	use yii\db\ActiveRecord;
class FieldsForm extends ActiveRecord
	{
		/*public $type;
		public $base;
		public $comment;
		public $amount;*/

		public function rules()
		{
			return [
				[['number_field', 'base', 'place', 'plane', 'plant'], 'required', 'message' => 'Поле должно быть заполнено']
			];
		}
		public static function tableName()
    	{
        	return 'fields';
    	}
	}
?>