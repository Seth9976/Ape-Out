using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000170 RID: 368
	public class RedefineEntry : Object
	{
		// Token: 0x06001B1A RID: 6938 RVA: 0x000853D4 File Offset: 0x000835D4
		// Note: this type is marked as 'beforefieldinit'.
		static RedefineEntry()
		{
			Il2CppClassPointerStore<RedefineEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "RedefineEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RedefineEntry>.NativeClassPtr);
			RedefineEntry.NativeFieldInfoPtr_redefine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RedefineEntry>.NativeClassPtr, "redefine");
			RedefineEntry.NativeFieldInfoPtr_schemaToUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RedefineEntry>.NativeClassPtr, "schemaToUpdate");
			RedefineEntry.NativeMethodInfoPtr__ctor_Public_Void_XmlSchemaRedefine_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RedefineEntry>.NativeClassPtr, 100667293);
		}

		// Token: 0x06001B1B RID: 6939 RVA: 0x00085440 File Offset: 0x00083640
		[CallerCount(76)]
		[CachedScanResults(RefRangeStart = 19789, RefRangeEnd = 19865, XrefRangeStart = 19789, XrefRangeEnd = 19865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RedefineEntry(XmlSchemaRedefine external, XmlSchema schema)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RedefineEntry>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(external);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schema);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RedefineEntry.NativeMethodInfoPtr__ctor_Public_Void_XmlSchemaRedefine_XmlSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B1C RID: 6940 RVA: 0x0000B812 File Offset: 0x00009A12
		public RedefineEntry(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000945 RID: 2373
		// (get) Token: 0x06001B1D RID: 6941 RVA: 0x000854A0 File Offset: 0x000836A0
		// (set) Token: 0x06001B1E RID: 6942 RVA: 0x0000B81B File Offset: 0x00009A1B
		public unsafe XmlSchemaRedefine redefine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RedefineEntry.NativeFieldInfoPtr_redefine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaRedefine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RedefineEntry.NativeFieldInfoPtr_redefine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000946 RID: 2374
		// (get) Token: 0x06001B1F RID: 6943 RVA: 0x000854D0 File Offset: 0x000836D0
		// (set) Token: 0x06001B20 RID: 6944 RVA: 0x0000B83A File Offset: 0x00009A3A
		public unsafe XmlSchema schemaToUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RedefineEntry.NativeFieldInfoPtr_schemaToUpdate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchema>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RedefineEntry.NativeFieldInfoPtr_schemaToUpdate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400143C RID: 5180
		private static readonly IntPtr NativeFieldInfoPtr_redefine;

		// Token: 0x0400143D RID: 5181
		private static readonly IntPtr NativeFieldInfoPtr_schemaToUpdate;

		// Token: 0x0400143E RID: 5182
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlSchemaRedefine_XmlSchema_0;
	}
}
