using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x0200037C RID: 892
	public sealed class SerObjectInfoInit : Object
	{
		// Token: 0x06003A0F RID: 14863 RVA: 0x0011774C File Offset: 0x0011594C
		// Note: this type is marked as 'beforefieldinit'.
		static SerObjectInfoInit()
		{
			Il2CppClassPointerStore<SerObjectInfoInit>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "SerObjectInfoInit");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerObjectInfoInit>.NativeClassPtr);
			SerObjectInfoInit.NativeFieldInfoPtr_seenBeforeTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerObjectInfoInit>.NativeClassPtr, "seenBeforeTable");
			SerObjectInfoInit.NativeFieldInfoPtr_objectInfoIdCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerObjectInfoInit>.NativeClassPtr, "objectInfoIdCount");
			SerObjectInfoInit.NativeFieldInfoPtr_oiPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerObjectInfoInit>.NativeClassPtr, "oiPool");
			SerObjectInfoInit.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerObjectInfoInit>.NativeClassPtr, 100672085);
		}

		// Token: 0x06003A10 RID: 14864 RVA: 0x001177CC File Offset: 0x001159CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 217113, RefRangeEnd = 217115, XrefRangeStart = 217103, XrefRangeEnd = 217113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerObjectInfoInit()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerObjectInfoInit>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerObjectInfoInit.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A11 RID: 14865 RVA: 0x0001526B File Offset: 0x0001346B
		public SerObjectInfoInit(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000E38 RID: 3640
		// (get) Token: 0x06003A12 RID: 14866 RVA: 0x00117808 File Offset: 0x00115A08
		// (set) Token: 0x06003A13 RID: 14867 RVA: 0x00015274 File Offset: 0x00013474
		public unsafe Hashtable seenBeforeTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerObjectInfoInit.NativeFieldInfoPtr_seenBeforeTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerObjectInfoInit.NativeFieldInfoPtr_seenBeforeTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E39 RID: 3641
		// (get) Token: 0x06003A14 RID: 14868 RVA: 0x00117838 File Offset: 0x00115A38
		// (set) Token: 0x06003A15 RID: 14869 RVA: 0x00015293 File Offset: 0x00013493
		public unsafe int objectInfoIdCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerObjectInfoInit.NativeFieldInfoPtr_objectInfoIdCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerObjectInfoInit.NativeFieldInfoPtr_objectInfoIdCount)) = value;
			}
		}

		// Token: 0x17000E3A RID: 3642
		// (get) Token: 0x06003A16 RID: 14870 RVA: 0x00117860 File Offset: 0x00115A60
		// (set) Token: 0x06003A17 RID: 14871 RVA: 0x000152AE File Offset: 0x000134AE
		public unsafe SerStack oiPool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerObjectInfoInit.NativeFieldInfoPtr_oiPool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerStack>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerObjectInfoInit.NativeFieldInfoPtr_oiPool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040030C2 RID: 12482
		private static readonly IntPtr NativeFieldInfoPtr_seenBeforeTable;

		// Token: 0x040030C3 RID: 12483
		private static readonly IntPtr NativeFieldInfoPtr_objectInfoIdCount;

		// Token: 0x040030C4 RID: 12484
		private static readonly IntPtr NativeFieldInfoPtr_oiPool;

		// Token: 0x040030C5 RID: 12485
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
