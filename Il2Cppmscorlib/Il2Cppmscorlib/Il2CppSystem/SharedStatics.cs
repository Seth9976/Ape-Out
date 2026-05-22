using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Security.Util;

namespace Il2CppSystem
{
	// Token: 0x020000E6 RID: 230
	public sealed class SharedStatics : Object
	{
		// Token: 0x06000FB4 RID: 4020 RVA: 0x0006BCF4 File Offset: 0x00069EF4
		// Note: this type is marked as 'beforefieldinit'.
		static SharedStatics()
		{
			Il2CppClassPointerStore<SharedStatics>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "SharedStatics");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SharedStatics>.NativeClassPtr);
			SharedStatics.NativeFieldInfoPtr__sharedStatics = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SharedStatics>.NativeClassPtr, "_sharedStatics");
			SharedStatics.NativeFieldInfoPtr__maker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SharedStatics>.NativeClassPtr, "_maker");
			SharedStatics.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedStatics>.NativeClassPtr, 100665987);
			SharedStatics.NativeMethodInfoPtr_GetSharedStringMaker_Public_Static_StringMaker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedStatics>.NativeClassPtr, 100665988);
			SharedStatics.NativeMethodInfoPtr_ReleaseSharedStringMaker_Public_Static_Void_byref_StringMaker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedStatics>.NativeClassPtr, 100665989);
		}

		// Token: 0x06000FB5 RID: 4021 RVA: 0x0006BD88 File Offset: 0x00069F88
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SharedStatics()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SharedStatics>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedStatics.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FB6 RID: 4022 RVA: 0x0006BDC4 File Offset: 0x00069FC4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 162759, RefRangeEnd = 162763, XrefRangeStart = 162735, XrefRangeEnd = 162759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tokenizer.StringMaker GetSharedStringMaker()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedStatics.NativeMethodInfoPtr_GetSharedStringMaker_Public_Static_StringMaker_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tokenizer.StringMaker>(intPtr3) : null;
		}

		// Token: 0x06000FB7 RID: 4023 RVA: 0x0006BDF8 File Offset: 0x00069FF8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 162774, RefRangeEnd = 162777, XrefRangeStart = 162763, XrefRangeEnd = 162774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReleaseSharedStringMaker(ref Tokenizer.StringMaker maker)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(maker);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SharedStatics.NativeMethodInfoPtr_ReleaseSharedStringMaker_Public_Static_Void_byref_StringMaker_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				maker = ((intPtr4 == 0) ? null : new Tokenizer.StringMaker(intPtr4));
			}
		}

		// Token: 0x06000FB8 RID: 4024 RVA: 0x00005EAF File Offset: 0x000040AF
		public SharedStatics(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x06000FB9 RID: 4025 RVA: 0x0006BE44 File Offset: 0x0006A044
		// (set) Token: 0x06000FBA RID: 4026 RVA: 0x00005EB8 File Offset: 0x000040B8
		public unsafe static SharedStatics _sharedStatics
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SharedStatics.NativeFieldInfoPtr__sharedStatics, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SharedStatics>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SharedStatics.NativeFieldInfoPtr__sharedStatics, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x06000FBB RID: 4027 RVA: 0x0006BE6C File Offset: 0x0006A06C
		// (set) Token: 0x06000FBC RID: 4028 RVA: 0x00005ECA File Offset: 0x000040CA
		public unsafe Tokenizer.StringMaker _maker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SharedStatics.NativeFieldInfoPtr__maker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tokenizer.StringMaker>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SharedStatics.NativeFieldInfoPtr__maker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000D5B RID: 3419
		private static readonly IntPtr NativeFieldInfoPtr__sharedStatics;

		// Token: 0x04000D5C RID: 3420
		private static readonly IntPtr NativeFieldInfoPtr__maker;

		// Token: 0x04000D5D RID: 3421
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04000D5E RID: 3422
		private static readonly IntPtr NativeMethodInfoPtr_GetSharedStringMaker_Public_Static_StringMaker_0;

		// Token: 0x04000D5F RID: 3423
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseSharedStringMaker_Public_Static_Void_byref_StringMaker_0;
	}
}
