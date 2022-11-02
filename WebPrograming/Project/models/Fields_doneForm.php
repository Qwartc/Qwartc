<?php
	namespace app\models;
	use yii\db\ActiveRecord;
class Fields_doneForm extends ActiveRecord
	{
		/*public $type;
		public $base;
		public $comment;
		public $amount;*/

		public function rules()
		{
			return [
				[['field_number', 'base', 'amount', 'who', 'field', 'type', 'technic', 'date'], 'required', 'message' => 'Поле должно быть заполнено']
			];
		}
		public static function tableName()
    	{
        	return 'fields_done';
    	}
	}
?>