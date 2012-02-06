
namespace DesignPatterns.Iterator
{
	/// <summary>
	/// 最後から取得していくイテレータ
	/// </summary>
	class PostIterator<Type> : AIterator<Type>
	{
		/// <summary>
		/// コンストラクタ
		/// </summary>
		/// <param name="type">使用する配列データ</param>
		public PostIterator(Type[] type)
			: base(type)
		{ 	}

		/// <summary>
		/// データを先頭にする
		/// </summary>
		public override void First()
		{
			// 最後から取得していくため、開始をMax-1にする
			index = list.Length - 1;
		}

		/// <summary>
		/// まだデータがあるかチェックする
		/// </summary>
		/// <returns>true:データ有,false:データ無</returns>
		public override bool IsDone()
		{
			// 0以上であればデータがまだある
			return (index >= 0 && list[index] != null);
		}

		/// <summary>
		/// データを次にする
		/// </summary>
		public override void Next()
		{			
			// 最後から先頭に向かうためデクリメント
			index--;
		}
	}
}
