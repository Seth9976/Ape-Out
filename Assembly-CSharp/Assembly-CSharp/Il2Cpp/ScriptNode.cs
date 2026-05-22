using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200017E RID: 382
	public class ScriptNode : global::Il2CppSystem.Object
	{
		// Token: 0x06002D4C RID: 11596 RVA: 0x000B12C8 File Offset: 0x000AF4C8
		// Note: this type is marked as 'beforefieldinit'.
		static ScriptNode()
		{
			Il2CppClassPointerStore<ScriptNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ScriptNode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptNode>.NativeClassPtr);
			ScriptNode.NativeFieldInfoPtr_anim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptNode>.NativeClassPtr, "anim");
			ScriptNode.NativeFieldInfoPtr_endAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptNode>.NativeClassPtr, "endAnim");
			ScriptNode.NativeFieldInfoPtr_attackSpot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptNode>.NativeClassPtr, "attackSpot");
			ScriptNode.NativeFieldInfoPtr_pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptNode>.NativeClassPtr, "pos");
			ScriptNode.NativeMethodInfoPtr__ctor_Private_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptNode>.NativeClassPtr, 100666818);
		}

		// Token: 0x06002D4D RID: 11597 RVA: 0x000B135C File Offset: 0x000AF55C
		[CallerCount(0)]
		public unsafe ScriptNode(Vector2 poo)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScriptNode>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref poo;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptNode.NativeMethodInfoPtr__ctor_Private_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002D4E RID: 11598 RVA: 0x0001F591 File Offset: 0x0001D791
		public ScriptNode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001042 RID: 4162
		// (get) Token: 0x06002D4F RID: 11599 RVA: 0x000B13A4 File Offset: 0x000AF5A4
		// (set) Token: 0x06002D50 RID: 11600 RVA: 0x0001F59A File Offset: 0x0001D79A
		public unsafe Animation anim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptNode.NativeFieldInfoPtr_anim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptNode.NativeFieldInfoPtr_anim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001043 RID: 4163
		// (get) Token: 0x06002D51 RID: 11601 RVA: 0x000B13D4 File Offset: 0x000AF5D4
		// (set) Token: 0x06002D52 RID: 11602 RVA: 0x0001F5B9 File Offset: 0x0001D7B9
		public unsafe bool endAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptNode.NativeFieldInfoPtr_endAnim);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptNode.NativeFieldInfoPtr_endAnim)) = value;
			}
		}

		// Token: 0x17001044 RID: 4164
		// (get) Token: 0x06002D53 RID: 11603 RVA: 0x000B13FC File Offset: 0x000AF5FC
		// (set) Token: 0x06002D54 RID: 11604 RVA: 0x0001F5D4 File Offset: 0x0001D7D4
		public unsafe Vector2 attackSpot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptNode.NativeFieldInfoPtr_attackSpot);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptNode.NativeFieldInfoPtr_attackSpot)) = value;
			}
		}

		// Token: 0x17001045 RID: 4165
		// (get) Token: 0x06002D55 RID: 11605 RVA: 0x000B1424 File Offset: 0x000AF624
		// (set) Token: 0x06002D56 RID: 11606 RVA: 0x0001F5EF File Offset: 0x0001D7EF
		public unsafe Vector2 pos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptNode.NativeFieldInfoPtr_pos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptNode.NativeFieldInfoPtr_pos)) = value;
			}
		}

		// Token: 0x04001AA9 RID: 6825
		private static readonly IntPtr NativeFieldInfoPtr_anim;

		// Token: 0x04001AAA RID: 6826
		private static readonly IntPtr NativeFieldInfoPtr_endAnim;

		// Token: 0x04001AAB RID: 6827
		private static readonly IntPtr NativeFieldInfoPtr_attackSpot;

		// Token: 0x04001AAC RID: 6828
		private static readonly IntPtr NativeFieldInfoPtr_pos;

		// Token: 0x04001AAD RID: 6829
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Vector2_0;
	}
}
