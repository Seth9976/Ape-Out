using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000173 RID: 371
	public class SchemaBuilder : Object
	{
		// Token: 0x06001BAE RID: 7086 RVA: 0x0008792C File Offset: 0x00085B2C
		// Note: this type is marked as 'beforefieldinit'.
		static SchemaBuilder()
		{
			Il2CppClassPointerStore<SchemaBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "SchemaBuilder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SchemaBuilder>.NativeClassPtr);
			SchemaBuilder.NativeMethodInfoPtr_ProcessElement_Internal_Abstract_Virtual_New_Boolean_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaBuilder>.NativeClassPtr, 100667376);
			SchemaBuilder.NativeMethodInfoPtr_ProcessAttribute_Internal_Abstract_Virtual_New_Void_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaBuilder>.NativeClassPtr, 100667377);
			SchemaBuilder.NativeMethodInfoPtr_IsContentParsed_Internal_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaBuilder>.NativeClassPtr, 100667378);
			SchemaBuilder.NativeMethodInfoPtr_ProcessMarkup_Internal_Abstract_Virtual_New_Void_Il2CppReferenceArray_1_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaBuilder>.NativeClassPtr, 100667379);
			SchemaBuilder.NativeMethodInfoPtr_ProcessCData_Internal_Abstract_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaBuilder>.NativeClassPtr, 100667380);
			SchemaBuilder.NativeMethodInfoPtr_StartChildren_Internal_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaBuilder>.NativeClassPtr, 100667381);
			SchemaBuilder.NativeMethodInfoPtr_EndChildren_Internal_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaBuilder>.NativeClassPtr, 100667382);
			SchemaBuilder.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaBuilder>.NativeClassPtr, 100667383);
		}

		// Token: 0x06001BAF RID: 7087 RVA: 0x000879FC File Offset: 0x00085BFC
		[CallerCount(0)]
		public unsafe virtual bool ProcessElement(string prefix, string name, string ns)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SchemaBuilder.NativeMethodInfoPtr_ProcessElement_Internal_Abstract_Virtual_New_Boolean_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BB0 RID: 7088 RVA: 0x00087A78 File Offset: 0x00085C78
		[CallerCount(0)]
		public unsafe virtual void ProcessAttribute(string prefix, string name, string ns, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SchemaBuilder.NativeMethodInfoPtr_ProcessAttribute_Internal_Abstract_Virtual_New_Void_String_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BB1 RID: 7089 RVA: 0x00087AFC File Offset: 0x00085CFC
		[CallerCount(0)]
		public unsafe virtual bool IsContentParsed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SchemaBuilder.NativeMethodInfoPtr_IsContentParsed_Internal_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BB2 RID: 7090 RVA: 0x00087B44 File Offset: 0x00085D44
		[CallerCount(0)]
		public unsafe virtual void ProcessMarkup(Il2CppReferenceArray<XmlNode> markup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(markup);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SchemaBuilder.NativeMethodInfoPtr_ProcessMarkup_Internal_Abstract_Virtual_New_Void_Il2CppReferenceArray_1_XmlNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001BB3 RID: 7091 RVA: 0x00087B94 File Offset: 0x00085D94
		[CallerCount(0)]
		public unsafe virtual void ProcessCData(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SchemaBuilder.NativeMethodInfoPtr_ProcessCData_Internal_Abstract_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001BB4 RID: 7092 RVA: 0x00087BE4 File Offset: 0x00085DE4
		[CallerCount(0)]
		public unsafe virtual void StartChildren()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SchemaBuilder.NativeMethodInfoPtr_StartChildren_Internal_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BB5 RID: 7093 RVA: 0x00087C20 File Offset: 0x00085E20
		[CallerCount(0)]
		public unsafe virtual void EndChildren()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SchemaBuilder.NativeMethodInfoPtr_EndChildren_Internal_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BB6 RID: 7094 RVA: 0x00087C5C File Offset: 0x00085E5C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SchemaBuilder()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SchemaBuilder>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaBuilder.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BB7 RID: 7095 RVA: 0x0000BB8D File Offset: 0x00009D8D
		public SchemaBuilder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040014AC RID: 5292
		private static readonly IntPtr NativeMethodInfoPtr_ProcessElement_Internal_Abstract_Virtual_New_Boolean_String_String_String_0;

		// Token: 0x040014AD RID: 5293
		private static readonly IntPtr NativeMethodInfoPtr_ProcessAttribute_Internal_Abstract_Virtual_New_Void_String_String_String_String_0;

		// Token: 0x040014AE RID: 5294
		private static readonly IntPtr NativeMethodInfoPtr_IsContentParsed_Internal_Abstract_Virtual_New_Boolean_0;

		// Token: 0x040014AF RID: 5295
		private static readonly IntPtr NativeMethodInfoPtr_ProcessMarkup_Internal_Abstract_Virtual_New_Void_Il2CppReferenceArray_1_XmlNode_0;

		// Token: 0x040014B0 RID: 5296
		private static readonly IntPtr NativeMethodInfoPtr_ProcessCData_Internal_Abstract_Virtual_New_Void_String_0;

		// Token: 0x040014B1 RID: 5297
		private static readonly IntPtr NativeMethodInfoPtr_StartChildren_Internal_Abstract_Virtual_New_Void_0;

		// Token: 0x040014B2 RID: 5298
		private static readonly IntPtr NativeMethodInfoPtr_EndChildren_Internal_Abstract_Virtual_New_Void_0;

		// Token: 0x040014B3 RID: 5299
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
