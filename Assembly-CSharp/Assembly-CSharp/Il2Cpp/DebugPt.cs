using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000185 RID: 389
	public class DebugPt : global::Il2CppSystem.Object
	{
		// Token: 0x06002E31 RID: 11825 RVA: 0x000B3B28 File Offset: 0x000B1D28
		// Note: this type is marked as 'beforefieldinit'.
		static DebugPt()
		{
			Il2CppClassPointerStore<DebugPt>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "DebugPt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugPt>.NativeClassPtr);
			DebugPt.NativeFieldInfoPtr_pt1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugPt>.NativeClassPtr, "pt1");
			DebugPt.NativeFieldInfoPtr_pt2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugPt>.NativeClassPtr, "pt2");
			DebugPt.NativeFieldInfoPtr_red = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugPt>.NativeClassPtr, "red");
			DebugPt.NativeMethodInfoPtr__ctor_Public_Void_Vector2_Vector2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugPt>.NativeClassPtr, 100666899);
		}

		// Token: 0x06002E32 RID: 11826 RVA: 0x000B3BA8 File Offset: 0x000B1DA8
		[CallerCount(0)]
		public unsafe DebugPt(Vector2 p1, Vector2 p2, bool rd)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugPt>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref p1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref p2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rd;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugPt.NativeMethodInfoPtr__ctor_Public_Void_Vector2_Vector2_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E33 RID: 11827 RVA: 0x0001FEC9 File Offset: 0x0001E0C9
		public DebugPt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001094 RID: 4244
		// (get) Token: 0x06002E34 RID: 11828 RVA: 0x000B3C0C File Offset: 0x000B1E0C
		// (set) Token: 0x06002E35 RID: 11829 RVA: 0x0001FED2 File Offset: 0x0001E0D2
		public unsafe Vector2 pt1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugPt.NativeFieldInfoPtr_pt1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugPt.NativeFieldInfoPtr_pt1)) = value;
			}
		}

		// Token: 0x17001095 RID: 4245
		// (get) Token: 0x06002E36 RID: 11830 RVA: 0x000B3C34 File Offset: 0x000B1E34
		// (set) Token: 0x06002E37 RID: 11831 RVA: 0x0001FEED File Offset: 0x0001E0ED
		public unsafe Vector2 pt2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugPt.NativeFieldInfoPtr_pt2);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugPt.NativeFieldInfoPtr_pt2)) = value;
			}
		}

		// Token: 0x17001096 RID: 4246
		// (get) Token: 0x06002E38 RID: 11832 RVA: 0x000B3C5C File Offset: 0x000B1E5C
		// (set) Token: 0x06002E39 RID: 11833 RVA: 0x0001FF08 File Offset: 0x0001E108
		public unsafe bool red
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugPt.NativeFieldInfoPtr_red);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugPt.NativeFieldInfoPtr_red)) = value;
			}
		}

		// Token: 0x04001B2E RID: 6958
		private static readonly IntPtr NativeFieldInfoPtr_pt1;

		// Token: 0x04001B2F RID: 6959
		private static readonly IntPtr NativeFieldInfoPtr_pt2;

		// Token: 0x04001B30 RID: 6960
		private static readonly IntPtr NativeFieldInfoPtr_red;

		// Token: 0x04001B31 RID: 6961
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector2_Vector2_Boolean_0;
	}
}
