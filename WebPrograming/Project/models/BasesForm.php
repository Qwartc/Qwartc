<?php
	namespace app\models;
	use yii\db\ActiveRecord;
class BasesForm extends ActiveRecord
	{
		/*public $type;
		public $base;
		public $comment;
		public $amount;*/

		public function rules()
		{
			return [
				[['name', 'plane', 'place'], 'required', 'message' => 'Поле должно быть заполнено']
			];
		}
		public static function tableName()
    	{
        	return 'bases';
    	}
	}
?>