<?php
	namespace app\models;
	use yii\db\ActiveRecord;
class ActionForm extends ActiveRecord
	{
		/*public $type;
		public $base;
		public $comment;
		public $amount;*/

		public function rules()
		{
			return [
				[['type', 'base', 'comment', 'amount'], 'required', 'message' => 'Поле должно быть заполнено']
			];
		}
		public static function tableName()
    	{
        	return 'action';
    	}
	}
?>