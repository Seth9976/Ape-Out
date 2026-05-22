using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000058 RID: 88
	public class SECTR_FPSController : SECTR_FPController
	{
		// Token: 0x06000CBC RID: 3260 RVA: 0x0005A718 File Offset: 0x00058918
		// Note: this type is marked as 'beforefieldinit'.
		static SECTR_FPSController()
		{
			Il2CppClassPointerStore<SECTR_FPSController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SECTR_FPSController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SECTR_FPSController>.NativeClassPtr);
			SECTR_FPSController.NativeFieldInfoPtr_cachedMotor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_FPSController>.NativeClassPtr, "cachedMotor");
			SECTR_FPSController.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_FPSController>.NativeClassPtr, 100664426);
			SECTR_FPSController.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_FPSController>.NativeClassPtr, 100664427);
			SECTR_FPSController.NativeMethodInfoPtr_ProjectOntoPlane_Private_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_FPSController>.NativeClassPtr, 100664428);
			SECTR_FPSController.NativeMethodInfoPtr_ConstantSlerp_Private_Vector3_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_FPSController>.NativeClassPtr, 100664429);
			SECTR_FPSController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_FPSController>.NativeClassPtr, 100664430);
		}

		// Token: 0x06000CBD RID: 3261 RVA: 0x0005A7C0 File Offset: 0x000589C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43328, XrefRangeEnd = 43331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_FPSController.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CBE RID: 3262 RVA: 0x0005A7F4 File Offset: 0x000589F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43331, XrefRangeEnd = 43369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SECTR_FPSController.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CBF RID: 3263 RVA: 0x0005A830 File Offset: 0x00058A30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43369, XrefRangeEnd = 43370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 ProjectOntoPlane(Vector3 v, Vector3 normal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref normal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_FPSController.NativeMethodInfoPtr_ProjectOntoPlane_Private_Vector3_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CC0 RID: 3264 RVA: 0x0005A888 File Offset: 0x00058A88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43370, XrefRangeEnd = 43373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 ConstantSlerp(Vector3 from, Vector3 to, float angle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref from;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref angle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_FPSController.NativeMethodInfoPtr_ConstantSlerp_Private_Vector3_Vector3_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CC1 RID: 3265 RVA: 0x0005A8F0 File Offset: 0x00058AF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43373, XrefRangeEnd = 43374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SECTR_FPSController()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SECTR_FPSController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_FPSController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CC2 RID: 3266 RVA: 0x00009BA2 File Offset: 0x00007DA2
		public SECTR_FPSController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x06000CC3 RID: 3267 RVA: 0x0005A92C File Offset: 0x00058B2C
		// (set) Token: 0x06000CC4 RID: 3268 RVA: 0x00009BAB File Offset: 0x00007DAB
		public unsafe SECTR_CharacterMotor cachedMotor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_FPSController.NativeFieldInfoPtr_cachedMotor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_CharacterMotor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_FPSController.NativeFieldInfoPtr_cachedMotor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040007D4 RID: 2004
		private static readonly IntPtr NativeFieldInfoPtr_cachedMotor;

		// Token: 0x040007D5 RID: 2005
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040007D6 RID: 2006
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x040007D7 RID: 2007
		private static readonly IntPtr NativeMethodInfoPtr_ProjectOntoPlane_Private_Vector3_Vector3_Vector3_0;

		// Token: 0x040007D8 RID: 2008
		private static readonly IntPtr NativeMethodInfoPtr_ConstantSlerp_Private_Vector3_Vector3_Vector3_Single_0;

		// Token: 0x040007D9 RID: 2009
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
