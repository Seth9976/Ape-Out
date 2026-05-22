using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x0200000B RID: 11
	public sealed class Tree : Component
	{
		// Token: 0x17000068 RID: 104
		// (get) Token: 0x0600010A RID: 266 RVA: 0x000057B0 File Offset: 0x000039B0
		// (set) Token: 0x0600010B RID: 267 RVA: 0x00002B9F File Offset: 0x00000D9F
		public ScriptableObject data
		{
			get
			{
				IntPtr intPtr = Tree.get_dataDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScriptableObject>(intPtr2) : null;
			}
			set
			{
				Tree.set_dataDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x0600010C RID: 268 RVA: 0x00002BB7 File Offset: 0x00000DB7
		public bool hasSpeedTreeWind
		{
			get
			{
				return Tree.get_hasSpeedTreeWindDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x040000C9 RID: 201
		private static readonly Tree.get_dataDelegate get_dataDelegateField = IL2CPP.ResolveICall<Tree.get_dataDelegate>("UnityEngine.Tree::get_data");

		// Token: 0x040000CA RID: 202
		private static readonly Tree.set_dataDelegate set_dataDelegateField = IL2CPP.ResolveICall<Tree.set_dataDelegate>("UnityEngine.Tree::set_data");

		// Token: 0x040000CB RID: 203
		private static readonly Tree.get_hasSpeedTreeWindDelegate get_hasSpeedTreeWindDelegateField = IL2CPP.ResolveICall<Tree.get_hasSpeedTreeWindDelegate>("UnityEngine.Tree::get_hasSpeedTreeWind");

		// Token: 0x020000AA RID: 170
		// (Invoke) Token: 0x060002F8 RID: 760
		private delegate IntPtr get_dataDelegate(IntPtr @this);

		// Token: 0x020000AB RID: 171
		// (Invoke) Token: 0x060002FA RID: 762
		private delegate void set_dataDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020000AC RID: 172
		// (Invoke) Token: 0x060002FC RID: 764
		private delegate bool get_hasSpeedTreeWindDelegate(IntPtr @this);
	}
}
