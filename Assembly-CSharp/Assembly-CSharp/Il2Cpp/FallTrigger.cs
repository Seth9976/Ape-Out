using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020000CB RID: 203
	public class FallTrigger : MonoBehaviour
	{
		// Token: 0x06001853 RID: 6227 RVA: 0x00078A84 File Offset: 0x00076C84
		// Note: this type is marked as 'beforefieldinit'.
		static FallTrigger()
		{
			Il2CppClassPointerStore<FallTrigger>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "FallTrigger");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FallTrigger>.NativeClassPtr);
			FallTrigger.NativeFieldInfoPtr_fallVect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FallTrigger>.NativeClassPtr, "fallVect");
			FallTrigger.NativeFieldInfoPtr_center = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FallTrigger>.NativeClassPtr, "center");
			FallTrigger.NativeFieldInfoPtr_playerString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FallTrigger>.NativeClassPtr, "playerString");
			FallTrigger.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FallTrigger>.NativeClassPtr, 100665290);
			FallTrigger.NativeMethodInfoPtr_OnTriggerStay2D_Public_Void_Collider2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FallTrigger>.NativeClassPtr, 100665291);
			FallTrigger.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FallTrigger>.NativeClassPtr, 100665292);
		}

		// Token: 0x06001854 RID: 6228 RVA: 0x00078B2C File Offset: 0x00076D2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57513, XrefRangeEnd = 57549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FallTrigger.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001855 RID: 6229 RVA: 0x00078B60 File Offset: 0x00076D60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57549, XrefRangeEnd = 57571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerStay2D(Collider2D coll)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(coll);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FallTrigger.NativeMethodInfoPtr_OnTriggerStay2D_Public_Void_Collider2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001856 RID: 6230 RVA: 0x00078BA4 File Offset: 0x00076DA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57571, XrefRangeEnd = 57576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FallTrigger()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FallTrigger>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FallTrigger.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001857 RID: 6231 RVA: 0x000117F2 File Offset: 0x0000F9F2
		public FallTrigger(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008CA RID: 2250
		// (get) Token: 0x06001858 RID: 6232 RVA: 0x00078BE0 File Offset: 0x00076DE0
		// (set) Token: 0x06001859 RID: 6233 RVA: 0x000117FB File Offset: 0x0000F9FB
		public unsafe Vector2 fallVect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FallTrigger.NativeFieldInfoPtr_fallVect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FallTrigger.NativeFieldInfoPtr_fallVect)) = value;
			}
		}

		// Token: 0x170008CB RID: 2251
		// (get) Token: 0x0600185A RID: 6234 RVA: 0x00078C08 File Offset: 0x00076E08
		// (set) Token: 0x0600185B RID: 6235 RVA: 0x00011816 File Offset: 0x0000FA16
		public unsafe Vector3 center
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FallTrigger.NativeFieldInfoPtr_center);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FallTrigger.NativeFieldInfoPtr_center)) = value;
			}
		}

		// Token: 0x170008CC RID: 2252
		// (get) Token: 0x0600185C RID: 6236 RVA: 0x00078C30 File Offset: 0x00076E30
		// (set) Token: 0x0600185D RID: 6237 RVA: 0x00011831 File Offset: 0x0000FA31
		public unsafe string playerString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FallTrigger.NativeFieldInfoPtr_playerString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FallTrigger.NativeFieldInfoPtr_playerString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000E7E RID: 3710
		private static readonly IntPtr NativeFieldInfoPtr_fallVect;

		// Token: 0x04000E7F RID: 3711
		private static readonly IntPtr NativeFieldInfoPtr_center;

		// Token: 0x04000E80 RID: 3712
		private static readonly IntPtr NativeFieldInfoPtr_playerString;

		// Token: 0x04000E81 RID: 3713
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x04000E82 RID: 3714
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerStay2D_Public_Void_Collider2D_0;

		// Token: 0x04000E83 RID: 3715
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
