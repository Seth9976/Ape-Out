using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using UnityEngine.Rendering;

namespace UnityEngine
{
	// Token: 0x0200025D RID: 605
	public sealed class ShaderVariantCollection : Object
	{
		// Token: 0x170006D1 RID: 1745
		// (get) Token: 0x060021CF RID: 8655 RVA: 0x00011F87 File Offset: 0x00010187
		public int shaderCount
		{
			get
			{
				return ShaderVariantCollection.get_shaderCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170006D2 RID: 1746
		// (get) Token: 0x060021D0 RID: 8656 RVA: 0x00011F99 File Offset: 0x00010199
		public int variantCount
		{
			get
			{
				return ShaderVariantCollection.get_variantCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170006D3 RID: 1747
		// (get) Token: 0x060021D1 RID: 8657 RVA: 0x00011FAB File Offset: 0x000101AB
		public bool isWarmedUp
		{
			get
			{
				return ShaderVariantCollection.get_isWarmedUpDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x060021D2 RID: 8658 RVA: 0x00011FBD File Offset: 0x000101BD
		public bool AddVariant(Shader shader, UnityEngine.Rendering.PassType passType, Il2CppStringArray keywords)
		{
			return ShaderVariantCollection.AddVariantDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(shader), passType, IL2CPP.Il2CppObjectBaseToPtr(keywords));
		}

		// Token: 0x060021D3 RID: 8659 RVA: 0x00011FDC File Offset: 0x000101DC
		public bool RemoveVariant(Shader shader, UnityEngine.Rendering.PassType passType, Il2CppStringArray keywords)
		{
			return ShaderVariantCollection.RemoveVariantDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(shader), passType, IL2CPP.Il2CppObjectBaseToPtr(keywords));
		}

		// Token: 0x060021D4 RID: 8660 RVA: 0x00011FFB File Offset: 0x000101FB
		public bool ContainsVariant(Shader shader, UnityEngine.Rendering.PassType passType, Il2CppStringArray keywords)
		{
			return ShaderVariantCollection.ContainsVariantDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(shader), passType, IL2CPP.Il2CppObjectBaseToPtr(keywords));
		}

		// Token: 0x060021D5 RID: 8661 RVA: 0x0001201A File Offset: 0x0001021A
		public void Clear()
		{
			ShaderVariantCollection.ClearDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060021D6 RID: 8662 RVA: 0x0001202C File Offset: 0x0001022C
		public void WarmUp()
		{
			ShaderVariantCollection.WarmUpDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060021D7 RID: 8663 RVA: 0x0001203E File Offset: 0x0001023E
		public static void Internal_Create(ShaderVariantCollection svc)
		{
			ShaderVariantCollection.Internal_CreateDelegateField(IL2CPP.Il2CppObjectBaseToPtr(svc));
		}

		// Token: 0x04001BE4 RID: 7140
		private static readonly ShaderVariantCollection.get_shaderCountDelegate get_shaderCountDelegateField = IL2CPP.ResolveICall<ShaderVariantCollection.get_shaderCountDelegate>("UnityEngine.ShaderVariantCollection::get_shaderCount");

		// Token: 0x04001BE5 RID: 7141
		private static readonly ShaderVariantCollection.get_variantCountDelegate get_variantCountDelegateField = IL2CPP.ResolveICall<ShaderVariantCollection.get_variantCountDelegate>("UnityEngine.ShaderVariantCollection::get_variantCount");

		// Token: 0x04001BE6 RID: 7142
		private static readonly ShaderVariantCollection.get_isWarmedUpDelegate get_isWarmedUpDelegateField = IL2CPP.ResolveICall<ShaderVariantCollection.get_isWarmedUpDelegate>("UnityEngine.ShaderVariantCollection::get_isWarmedUp");

		// Token: 0x04001BE7 RID: 7143
		private static readonly ShaderVariantCollection.AddVariantDelegate AddVariantDelegateField = IL2CPP.ResolveICall<ShaderVariantCollection.AddVariantDelegate>("UnityEngine.ShaderVariantCollection::AddVariant");

		// Token: 0x04001BE8 RID: 7144
		private static readonly ShaderVariantCollection.RemoveVariantDelegate RemoveVariantDelegateField = IL2CPP.ResolveICall<ShaderVariantCollection.RemoveVariantDelegate>("UnityEngine.ShaderVariantCollection::RemoveVariant");

		// Token: 0x04001BE9 RID: 7145
		private static readonly ShaderVariantCollection.ContainsVariantDelegate ContainsVariantDelegateField = IL2CPP.ResolveICall<ShaderVariantCollection.ContainsVariantDelegate>("UnityEngine.ShaderVariantCollection::ContainsVariant");

		// Token: 0x04001BEA RID: 7146
		private static readonly ShaderVariantCollection.ClearDelegate ClearDelegateField = IL2CPP.ResolveICall<ShaderVariantCollection.ClearDelegate>("UnityEngine.ShaderVariantCollection::Clear");

		// Token: 0x04001BEB RID: 7147
		private static readonly ShaderVariantCollection.WarmUpDelegate WarmUpDelegateField = IL2CPP.ResolveICall<ShaderVariantCollection.WarmUpDelegate>("UnityEngine.ShaderVariantCollection::WarmUp");

		// Token: 0x04001BEC RID: 7148
		private static readonly ShaderVariantCollection.Internal_CreateDelegate Internal_CreateDelegateField = IL2CPP.ResolveICall<ShaderVariantCollection.Internal_CreateDelegate>("UnityEngine.ShaderVariantCollection::Internal_Create");

		// Token: 0x02000B92 RID: 2962
		// (Invoke) Token: 0x06003584 RID: 13700
		private delegate int get_shaderCountDelegate(IntPtr @this);

		// Token: 0x02000B93 RID: 2963
		// (Invoke) Token: 0x06003586 RID: 13702
		private delegate int get_variantCountDelegate(IntPtr @this);

		// Token: 0x02000B94 RID: 2964
		// (Invoke) Token: 0x06003588 RID: 13704
		private delegate bool get_isWarmedUpDelegate(IntPtr @this);

		// Token: 0x02000B95 RID: 2965
		// (Invoke) Token: 0x0600358A RID: 13706
		private delegate bool AddVariantDelegate(IntPtr @this, IntPtr shader, UnityEngine.Rendering.PassType passType, IntPtr keywords);

		// Token: 0x02000B96 RID: 2966
		// (Invoke) Token: 0x0600358C RID: 13708
		private delegate bool RemoveVariantDelegate(IntPtr @this, IntPtr shader, UnityEngine.Rendering.PassType passType, IntPtr keywords);

		// Token: 0x02000B97 RID: 2967
		// (Invoke) Token: 0x0600358E RID: 13710
		private delegate bool ContainsVariantDelegate(IntPtr @this, IntPtr shader, UnityEngine.Rendering.PassType passType, IntPtr keywords);

		// Token: 0x02000B98 RID: 2968
		// (Invoke) Token: 0x06003590 RID: 13712
		private delegate void ClearDelegate(IntPtr @this);

		// Token: 0x02000B99 RID: 2969
		// (Invoke) Token: 0x06003592 RID: 13714
		private delegate void WarmUpDelegate(IntPtr @this);

		// Token: 0x02000B9A RID: 2970
		// (Invoke) Token: 0x06003594 RID: 13716
		private delegate void Internal_CreateDelegate(IntPtr svc);
	}
}
