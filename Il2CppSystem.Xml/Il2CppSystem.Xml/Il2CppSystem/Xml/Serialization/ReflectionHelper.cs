using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000BD RID: 189
	public class ReflectionHelper : Object
	{
		// Token: 0x0600111A RID: 4378 RVA: 0x0005E858 File Offset: 0x0005CA58
		// Note: this type is marked as 'beforefieldinit'.
		static ReflectionHelper()
		{
			Il2CppClassPointerStore<ReflectionHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "ReflectionHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReflectionHelper>.NativeClassPtr);
			ReflectionHelper.NativeFieldInfoPtr__clrTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionHelper>.NativeClassPtr, "_clrTypes");
			ReflectionHelper.NativeFieldInfoPtr__schemaTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionHelper>.NativeClassPtr, "_schemaTypes");
			ReflectionHelper.NativeFieldInfoPtr_empty_modifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionHelper>.NativeClassPtr, "empty_modifiers");
			ReflectionHelper.NativeMethodInfoPtr_RegisterSchemaType_Public_Void_XmlTypeMapping_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionHelper>.NativeClassPtr, 100666040);
			ReflectionHelper.NativeMethodInfoPtr_GetRegisteredSchemaType_Public_XmlTypeMapping_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionHelper>.NativeClassPtr, 100666041);
			ReflectionHelper.NativeMethodInfoPtr_RegisterClrType_Public_Void_XmlTypeMapping_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionHelper>.NativeClassPtr, 100666042);
			ReflectionHelper.NativeMethodInfoPtr_GetRegisteredClrType_Public_XmlTypeMapping_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionHelper>.NativeClassPtr, 100666043);
			ReflectionHelper.NativeMethodInfoPtr_CheckSerializableType_Public_Static_Void_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionHelper>.NativeClassPtr, 100666044);
			ReflectionHelper.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionHelper>.NativeClassPtr, 100666045);
		}

		// Token: 0x0600111B RID: 4379 RVA: 0x0005E93C File Offset: 0x0005CB3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 403599, RefRangeEnd = 403600, XrefRangeStart = 403596, XrefRangeEnd = 403599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterSchemaType(XmlTypeMapping map, string xmlType, string ns)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(map);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(xmlType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionHelper.NativeMethodInfoPtr_RegisterSchemaType_Public_Void_XmlTypeMapping_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600111C RID: 4380 RVA: 0x0005E9A4 File Offset: 0x0005CBA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 403600, XrefRangeEnd = 403604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTypeMapping GetRegisteredSchemaType(string xmlType, string ns)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(xmlType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionHelper.NativeMethodInfoPtr_GetRegisteredSchemaType_Public_XmlTypeMapping_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlTypeMapping>(intPtr3) : null;
		}

		// Token: 0x0600111D RID: 4381 RVA: 0x0005EA08 File Offset: 0x0005CC08
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 403615, RefRangeEnd = 403620, XrefRangeStart = 403604, XrefRangeEnd = 403615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterClrType(XmlTypeMapping map, Type type, string ns)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(map);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionHelper.NativeMethodInfoPtr_RegisterClrType_Public_Void_XmlTypeMapping_Type_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600111E RID: 4382 RVA: 0x0005EA70 File Offset: 0x0005CC70
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 403632, RefRangeEnd = 403637, XrefRangeStart = 403620, XrefRangeEnd = 403632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTypeMapping GetRegisteredClrType(Type type, string ns)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionHelper.NativeMethodInfoPtr_GetRegisteredClrType_Public_XmlTypeMapping_Type_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlTypeMapping>(intPtr3) : null;
		}

		// Token: 0x0600111F RID: 4383 RVA: 0x0005EAD4 File Offset: 0x0005CCD4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 403658, RefRangeEnd = 403662, XrefRangeStart = 403637, XrefRangeEnd = 403658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CheckSerializableType(Type type, bool allowPrivateConstructors)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowPrivateConstructors;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionHelper.NativeMethodInfoPtr_CheckSerializableType_Public_Static_Void_Type_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001120 RID: 4384 RVA: 0x0005EB18 File Offset: 0x0005CD18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 403662, XrefRangeEnd = 403669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReflectionHelper()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReflectionHelper>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionHelper.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001121 RID: 4385 RVA: 0x00007928 File Offset: 0x00005B28
		public ReflectionHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x06001122 RID: 4386 RVA: 0x0005EB54 File Offset: 0x0005CD54
		// (set) Token: 0x06001123 RID: 4387 RVA: 0x00007931 File Offset: 0x00005B31
		public unsafe Hashtable _clrTypes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionHelper.NativeFieldInfoPtr__clrTypes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionHelper.NativeFieldInfoPtr__clrTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x06001124 RID: 4388 RVA: 0x0005EB84 File Offset: 0x0005CD84
		// (set) Token: 0x06001125 RID: 4389 RVA: 0x00007950 File Offset: 0x00005B50
		public unsafe Hashtable _schemaTypes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionHelper.NativeFieldInfoPtr__schemaTypes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionHelper.NativeFieldInfoPtr__schemaTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x06001126 RID: 4390 RVA: 0x0005EBB4 File Offset: 0x0005CDB4
		// (set) Token: 0x06001127 RID: 4391 RVA: 0x0000796F File Offset: 0x00005B6F
		public unsafe static Il2CppReferenceArray<ParameterModifier> empty_modifiers
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ReflectionHelper.NativeFieldInfoPtr_empty_modifiers, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ParameterModifier>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReflectionHelper.NativeFieldInfoPtr_empty_modifiers, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000D80 RID: 3456
		private static readonly IntPtr NativeFieldInfoPtr__clrTypes;

		// Token: 0x04000D81 RID: 3457
		private static readonly IntPtr NativeFieldInfoPtr__schemaTypes;

		// Token: 0x04000D82 RID: 3458
		private static readonly IntPtr NativeFieldInfoPtr_empty_modifiers;

		// Token: 0x04000D83 RID: 3459
		private static readonly IntPtr NativeMethodInfoPtr_RegisterSchemaType_Public_Void_XmlTypeMapping_String_String_0;

		// Token: 0x04000D84 RID: 3460
		private static readonly IntPtr NativeMethodInfoPtr_GetRegisteredSchemaType_Public_XmlTypeMapping_String_String_0;

		// Token: 0x04000D85 RID: 3461
		private static readonly IntPtr NativeMethodInfoPtr_RegisterClrType_Public_Void_XmlTypeMapping_Type_String_0;

		// Token: 0x04000D86 RID: 3462
		private static readonly IntPtr NativeMethodInfoPtr_GetRegisteredClrType_Public_XmlTypeMapping_Type_String_0;

		// Token: 0x04000D87 RID: 3463
		private static readonly IntPtr NativeMethodInfoPtr_CheckSerializableType_Public_Static_Void_Type_Boolean_0;

		// Token: 0x04000D88 RID: 3464
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
