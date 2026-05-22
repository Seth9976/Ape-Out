using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000388 RID: 904
	public sealed class InternalFE : Object
	{
		// Token: 0x06003BD0 RID: 15312 RVA: 0x0011D49C File Offset: 0x0011B69C
		// Note: this type is marked as 'beforefieldinit'.
		static InternalFE()
		{
			Il2CppClassPointerStore<InternalFE>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "InternalFE");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InternalFE>.NativeClassPtr);
			InternalFE.NativeFieldInfoPtr_FEtypeFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalFE>.NativeClassPtr, "FEtypeFormat");
			InternalFE.NativeFieldInfoPtr_FEassemblyFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalFE>.NativeClassPtr, "FEassemblyFormat");
			InternalFE.NativeFieldInfoPtr_FEsecurityLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalFE>.NativeClassPtr, "FEsecurityLevel");
			InternalFE.NativeFieldInfoPtr_FEserializerTypeEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalFE>.NativeClassPtr, "FEserializerTypeEnum");
			InternalFE.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalFE>.NativeClassPtr, 100672236);
		}

		// Token: 0x06003BD1 RID: 15313 RVA: 0x0011D530 File Offset: 0x0011B730
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InternalFE()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InternalFE>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InternalFE.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003BD2 RID: 15314 RVA: 0x00016310 File Offset: 0x00014510
		public InternalFE(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000ED0 RID: 3792
		// (get) Token: 0x06003BD3 RID: 15315 RVA: 0x0011D56C File Offset: 0x0011B76C
		// (set) Token: 0x06003BD4 RID: 15316 RVA: 0x00016319 File Offset: 0x00014519
		public unsafe FormatterTypeStyle FEtypeFormat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalFE.NativeFieldInfoPtr_FEtypeFormat);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalFE.NativeFieldInfoPtr_FEtypeFormat)) = value;
			}
		}

		// Token: 0x17000ED1 RID: 3793
		// (get) Token: 0x06003BD5 RID: 15317 RVA: 0x0011D594 File Offset: 0x0011B794
		// (set) Token: 0x06003BD6 RID: 15318 RVA: 0x00016334 File Offset: 0x00014534
		public unsafe FormatterAssemblyStyle FEassemblyFormat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalFE.NativeFieldInfoPtr_FEassemblyFormat);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalFE.NativeFieldInfoPtr_FEassemblyFormat)) = value;
			}
		}

		// Token: 0x17000ED2 RID: 3794
		// (get) Token: 0x06003BD7 RID: 15319 RVA: 0x0011D5BC File Offset: 0x0011B7BC
		// (set) Token: 0x06003BD8 RID: 15320 RVA: 0x0001634F File Offset: 0x0001454F
		public unsafe TypeFilterLevel FEsecurityLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalFE.NativeFieldInfoPtr_FEsecurityLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalFE.NativeFieldInfoPtr_FEsecurityLevel)) = value;
			}
		}

		// Token: 0x17000ED3 RID: 3795
		// (get) Token: 0x06003BD9 RID: 15321 RVA: 0x0011D5E4 File Offset: 0x0011B7E4
		// (set) Token: 0x06003BDA RID: 15322 RVA: 0x0001636A File Offset: 0x0001456A
		public unsafe InternalSerializerTypeE FEserializerTypeEnum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalFE.NativeFieldInfoPtr_FEserializerTypeEnum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalFE.NativeFieldInfoPtr_FEserializerTypeEnum)) = value;
			}
		}

		// Token: 0x040031DF RID: 12767
		private static readonly IntPtr NativeFieldInfoPtr_FEtypeFormat;

		// Token: 0x040031E0 RID: 12768
		private static readonly IntPtr NativeFieldInfoPtr_FEassemblyFormat;

		// Token: 0x040031E1 RID: 12769
		private static readonly IntPtr NativeFieldInfoPtr_FEsecurityLevel;

		// Token: 0x040031E2 RID: 12770
		private static readonly IntPtr NativeFieldInfoPtr_FEserializerTypeEnum;

		// Token: 0x040031E3 RID: 12771
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
