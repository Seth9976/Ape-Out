using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200018C RID: 396
	public class SightUtil : MonoBehaviour
	{
		// Token: 0x06002EE2 RID: 12002 RVA: 0x000B597C File Offset: 0x000B3B7C
		// Note: this type is marked as 'beforefieldinit'.
		static SightUtil()
		{
			Il2CppClassPointerStore<SightUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SightUtil");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SightUtil>.NativeClassPtr);
			SightUtil.NativeFieldInfoPtr_onSeen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SightUtil>.NativeClassPtr, "onSeen");
			SightUtil.NativeMethodInfoPtr_Scan_Public_Static_Void_GameObject_Vector2_Single_Single_Single_LayerMask_Il2CppReferenceArray_1_Collider2D_Il2CppStructArray_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SightUtil>.NativeClassPtr, 100666968);
			SightUtil.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SightUtil>.NativeClassPtr, 100666969);
		}

		// Token: 0x06002EE3 RID: 12003 RVA: 0x000B59E8 File Offset: 0x000B3BE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 83003, RefRangeEnd = 83004, XrefRangeStart = 82938, XrefRangeEnd = 83003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Scan(GameObject me, Vector2 pos, float rot, float deg, float dist, LayerMask layers, Il2CppReferenceArray<Collider2D> colArr, Il2CppStructArray<Vector2> pts)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(me);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rot;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deg;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dist;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layers;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(colArr);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pts);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SightUtil.NativeMethodInfoPtr_Scan_Public_Static_Void_GameObject_Vector2_Single_Single_Single_LayerMask_Il2CppReferenceArray_1_Collider2D_Il2CppStructArray_1_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EE4 RID: 12004 RVA: 0x000B5A8C File Offset: 0x000B3C8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SightUtil()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SightUtil>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SightUtil.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EE5 RID: 12005 RVA: 0x000205B5 File Offset: 0x0001E7B5
		public SightUtil(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170010D0 RID: 4304
		// (get) Token: 0x06002EE6 RID: 12006 RVA: 0x000B5AC8 File Offset: 0x000B3CC8
		// (set) Token: 0x06002EE7 RID: 12007 RVA: 0x000205BE File Offset: 0x0001E7BE
		public unsafe static string onSeen
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SightUtil.NativeFieldInfoPtr_onSeen, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SightUtil.NativeFieldInfoPtr_onSeen, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001B9A RID: 7066
		private static readonly IntPtr NativeFieldInfoPtr_onSeen;

		// Token: 0x04001B9B RID: 7067
		private static readonly IntPtr NativeMethodInfoPtr_Scan_Public_Static_Void_GameObject_Vector2_Single_Single_Single_LayerMask_Il2CppReferenceArray_1_Collider2D_Il2CppStructArray_1_Vector2_0;

		// Token: 0x04001B9C RID: 7068
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
