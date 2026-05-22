using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020001A4 RID: 420
	public class SpriteOverApe : MonoBehaviour
	{
		// Token: 0x0600304D RID: 12365 RVA: 0x000B9508 File Offset: 0x000B7708
		// Note: this type is marked as 'beforefieldinit'.
		static SpriteOverApe()
		{
			Il2CppClassPointerStore<SpriteOverApe>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SpriteOverApe");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteOverApe>.NativeClassPtr);
			SpriteOverApe.NativeFieldInfoPtr_topper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteOverApe>.NativeClassPtr, "topper");
			SpriteOverApe.NativeFieldInfoPtr_toppers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteOverApe>.NativeClassPtr, "toppers");
			SpriteOverApe.NativeFieldInfoPtr_def = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteOverApe>.NativeClassPtr, "def");
			SpriteOverApe.NativeFieldInfoPtr_forg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteOverApe>.NativeClassPtr, "forg");
			SpriteOverApe.NativeFieldInfoPtr_curSort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteOverApe>.NativeClassPtr, "curSort");
			SpriteOverApe.NativeFieldInfoPtr_myPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteOverApe>.NativeClassPtr, "myPos");
			SpriteOverApe.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteOverApe>.NativeClassPtr, 100667080);
			SpriteOverApe.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteOverApe>.NativeClassPtr, 100667081);
			SpriteOverApe.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteOverApe>.NativeClassPtr, 100667082);
			SpriteOverApe.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteOverApe>.NativeClassPtr, 100667083);
		}

		// Token: 0x0600304E RID: 12366 RVA: 0x000B9600 File Offset: 0x000B7800
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84230, XrefRangeEnd = 84251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteOverApe.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600304F RID: 12367 RVA: 0x000B9634 File Offset: 0x000B7834
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84251, XrefRangeEnd = 84255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteOverApe.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003050 RID: 12368 RVA: 0x000B9668 File Offset: 0x000B7868
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84255, XrefRangeEnd = 84291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteOverApe.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003051 RID: 12369 RVA: 0x000B969C File Offset: 0x000B789C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpriteOverApe()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpriteOverApe>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteOverApe.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003052 RID: 12370 RVA: 0x000213B9 File Offset: 0x0001F5B9
		public SpriteOverApe(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001145 RID: 4421
		// (get) Token: 0x06003053 RID: 12371 RVA: 0x000B96D8 File Offset: 0x000B78D8
		// (set) Token: 0x06003054 RID: 12372 RVA: 0x000213C2 File Offset: 0x0001F5C2
		public unsafe Renderer topper
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteOverApe.NativeFieldInfoPtr_topper);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Renderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteOverApe.NativeFieldInfoPtr_topper), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001146 RID: 4422
		// (get) Token: 0x06003055 RID: 12373 RVA: 0x000B9708 File Offset: 0x000B7908
		// (set) Token: 0x06003056 RID: 12374 RVA: 0x000213E1 File Offset: 0x0001F5E1
		public unsafe Il2CppReferenceArray<Renderer> toppers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteOverApe.NativeFieldInfoPtr_toppers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Renderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteOverApe.NativeFieldInfoPtr_toppers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001147 RID: 4423
		// (get) Token: 0x06003057 RID: 12375 RVA: 0x000B9738 File Offset: 0x000B7938
		// (set) Token: 0x06003058 RID: 12376 RVA: 0x00021400 File Offset: 0x0001F600
		public unsafe int def
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteOverApe.NativeFieldInfoPtr_def);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteOverApe.NativeFieldInfoPtr_def)) = value;
			}
		}

		// Token: 0x17001148 RID: 4424
		// (get) Token: 0x06003059 RID: 12377 RVA: 0x000B9760 File Offset: 0x000B7960
		// (set) Token: 0x0600305A RID: 12378 RVA: 0x0002141B File Offset: 0x0001F61B
		public unsafe int forg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteOverApe.NativeFieldInfoPtr_forg);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteOverApe.NativeFieldInfoPtr_forg)) = value;
			}
		}

		// Token: 0x17001149 RID: 4425
		// (get) Token: 0x0600305B RID: 12379 RVA: 0x000B9788 File Offset: 0x000B7988
		// (set) Token: 0x0600305C RID: 12380 RVA: 0x00021436 File Offset: 0x0001F636
		public unsafe int curSort
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteOverApe.NativeFieldInfoPtr_curSort);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteOverApe.NativeFieldInfoPtr_curSort)) = value;
			}
		}

		// Token: 0x1700114A RID: 4426
		// (get) Token: 0x0600305D RID: 12381 RVA: 0x000B97B0 File Offset: 0x000B79B0
		// (set) Token: 0x0600305E RID: 12382 RVA: 0x00021451 File Offset: 0x0001F651
		public unsafe Vector2 myPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteOverApe.NativeFieldInfoPtr_myPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteOverApe.NativeFieldInfoPtr_myPos)) = value;
			}
		}

		// Token: 0x04001C60 RID: 7264
		private static readonly IntPtr NativeFieldInfoPtr_topper;

		// Token: 0x04001C61 RID: 7265
		private static readonly IntPtr NativeFieldInfoPtr_toppers;

		// Token: 0x04001C62 RID: 7266
		private static readonly IntPtr NativeFieldInfoPtr_def;

		// Token: 0x04001C63 RID: 7267
		private static readonly IntPtr NativeFieldInfoPtr_forg;

		// Token: 0x04001C64 RID: 7268
		private static readonly IntPtr NativeFieldInfoPtr_curSort;

		// Token: 0x04001C65 RID: 7269
		private static readonly IntPtr NativeFieldInfoPtr_myPos;

		// Token: 0x04001C66 RID: 7270
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04001C67 RID: 7271
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04001C68 RID: 7272
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04001C69 RID: 7273
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
