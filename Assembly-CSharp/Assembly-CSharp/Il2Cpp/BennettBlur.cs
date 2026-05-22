using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000078 RID: 120
	public class BennettBlur : MonoBehaviour
	{
		// Token: 0x06000F56 RID: 3926 RVA: 0x000612FC File Offset: 0x0005F4FC
		// Note: this type is marked as 'beforefieldinit'.
		static BennettBlur()
		{
			Il2CppClassPointerStore<BennettBlur>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "BennettBlur");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BennettBlur>.NativeClassPtr);
			BennettBlur.NativeFieldInfoPtr_b1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BennettBlur>.NativeClassPtr, "b1");
			BennettBlur.NativeFieldInfoPtr_c = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BennettBlur>.NativeClassPtr, "c");
			BennettBlur.NativeFieldInfoPtr_intermediates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BennettBlur>.NativeClassPtr, "intermediates");
			BennettBlur.NativeFieldInfoPtr_passes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BennettBlur>.NativeClassPtr, "passes");
			BennettBlur.NativeFieldInfoPtr_amounts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BennettBlur>.NativeClassPtr, "amounts");
			BennettBlur.NativeFieldInfoPtr_Exponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BennettBlur>.NativeClassPtr, "Exponent");
			BennettBlur.NativeFieldInfoPtr_Scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BennettBlur>.NativeClassPtr, "Scale");
			BennettBlur.NativeFieldInfoPtr_me = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BennettBlur>.NativeClassPtr, "me");
			BennettBlur.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BennettBlur>.NativeClassPtr, 100664614);
			BennettBlur.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BennettBlur>.NativeClassPtr, 100664615);
			BennettBlur.NativeMethodInfoPtr_OnPreRender_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BennettBlur>.NativeClassPtr, 100664616);
			BennettBlur.NativeMethodInfoPtr_OnRenderImage_Private_Void_RenderTexture_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BennettBlur>.NativeClassPtr, 100664617);
			BennettBlur.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BennettBlur>.NativeClassPtr, 100664618);
		}

		// Token: 0x06000F57 RID: 3927 RVA: 0x00061430 File Offset: 0x0005F630
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46680, XrefRangeEnd = 46720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BennettBlur.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F58 RID: 3928 RVA: 0x00061464 File Offset: 0x0005F664
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46720, XrefRangeEnd = 46723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BennettBlur.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F59 RID: 3929 RVA: 0x00061498 File Offset: 0x0005F698
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPreRender()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BennettBlur.NativeMethodInfoPtr_OnPreRender_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F5A RID: 3930 RVA: 0x000614CC File Offset: 0x0005F6CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46723, XrefRangeEnd = 46760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destination);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BennettBlur.NativeMethodInfoPtr_OnRenderImage_Private_Void_RenderTexture_RenderTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F5B RID: 3931 RVA: 0x00061520 File Offset: 0x0005F720
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46760, XrefRangeEnd = 46769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BennettBlur()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BennettBlur>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BennettBlur.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F5C RID: 3932 RVA: 0x0000B688 File Offset: 0x00009888
		public BennettBlur(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x06000F5D RID: 3933 RVA: 0x0006155C File Offset: 0x0005F75C
		// (set) Token: 0x06000F5E RID: 3934 RVA: 0x0000B691 File Offset: 0x00009891
		public unsafe Material b1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BennettBlur.NativeFieldInfoPtr_b1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BennettBlur.NativeFieldInfoPtr_b1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x06000F5F RID: 3935 RVA: 0x0006158C File Offset: 0x0005F78C
		// (set) Token: 0x06000F60 RID: 3936 RVA: 0x0000B6B0 File Offset: 0x000098B0
		public unsafe Camera c
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BennettBlur.NativeFieldInfoPtr_c);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BennettBlur.NativeFieldInfoPtr_c), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x06000F61 RID: 3937 RVA: 0x000615BC File Offset: 0x0005F7BC
		// (set) Token: 0x06000F62 RID: 3938 RVA: 0x0000B6CF File Offset: 0x000098CF
		public unsafe Il2CppReferenceArray<RenderTexture> intermediates
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BennettBlur.NativeFieldInfoPtr_intermediates);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RenderTexture>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BennettBlur.NativeFieldInfoPtr_intermediates), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x06000F63 RID: 3939 RVA: 0x000615EC File Offset: 0x0005F7EC
		// (set) Token: 0x06000F64 RID: 3940 RVA: 0x0000B6EE File Offset: 0x000098EE
		public unsafe int passes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BennettBlur.NativeFieldInfoPtr_passes);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BennettBlur.NativeFieldInfoPtr_passes)) = value;
			}
		}

		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x06000F65 RID: 3941 RVA: 0x00061614 File Offset: 0x0005F814
		// (set) Token: 0x06000F66 RID: 3942 RVA: 0x0000B709 File Offset: 0x00009909
		public unsafe Il2CppStructArray<int> amounts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BennettBlur.NativeFieldInfoPtr_amounts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BennettBlur.NativeFieldInfoPtr_amounts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x06000F67 RID: 3943 RVA: 0x00061644 File Offset: 0x0005F844
		// (set) Token: 0x06000F68 RID: 3944 RVA: 0x0000B728 File Offset: 0x00009928
		public unsafe float Exponent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BennettBlur.NativeFieldInfoPtr_Exponent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BennettBlur.NativeFieldInfoPtr_Exponent)) = value;
			}
		}

		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x06000F69 RID: 3945 RVA: 0x0006166C File Offset: 0x0005F86C
		// (set) Token: 0x06000F6A RID: 3946 RVA: 0x0000B743 File Offset: 0x00009943
		public unsafe float Scale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BennettBlur.NativeFieldInfoPtr_Scale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BennettBlur.NativeFieldInfoPtr_Scale)) = value;
			}
		}

		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x06000F6B RID: 3947 RVA: 0x00061694 File Offset: 0x0005F894
		// (set) Token: 0x06000F6C RID: 3948 RVA: 0x0000B75E File Offset: 0x0000995E
		public unsafe static BennettBlur me
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BennettBlur.NativeFieldInfoPtr_me, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BennettBlur>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BennettBlur.NativeFieldInfoPtr_me, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400095C RID: 2396
		private static readonly IntPtr NativeFieldInfoPtr_b1;

		// Token: 0x0400095D RID: 2397
		private static readonly IntPtr NativeFieldInfoPtr_c;

		// Token: 0x0400095E RID: 2398
		private static readonly IntPtr NativeFieldInfoPtr_intermediates;

		// Token: 0x0400095F RID: 2399
		private static readonly IntPtr NativeFieldInfoPtr_passes;

		// Token: 0x04000960 RID: 2400
		private static readonly IntPtr NativeFieldInfoPtr_amounts;

		// Token: 0x04000961 RID: 2401
		private static readonly IntPtr NativeFieldInfoPtr_Exponent;

		// Token: 0x04000962 RID: 2402
		private static readonly IntPtr NativeFieldInfoPtr_Scale;

		// Token: 0x04000963 RID: 2403
		private static readonly IntPtr NativeFieldInfoPtr_me;

		// Token: 0x04000964 RID: 2404
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04000965 RID: 2405
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04000966 RID: 2406
		private static readonly IntPtr NativeMethodInfoPtr_OnPreRender_Private_Void_0;

		// Token: 0x04000967 RID: 2407
		private static readonly IntPtr NativeMethodInfoPtr_OnRenderImage_Private_Void_RenderTexture_RenderTexture_0;

		// Token: 0x04000968 RID: 2408
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
