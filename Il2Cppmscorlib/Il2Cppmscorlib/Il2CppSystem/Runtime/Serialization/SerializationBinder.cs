using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x02000344 RID: 836
	[Serializable]
	public class SerializationBinder : Object
	{
		// Token: 0x06003696 RID: 13974 RVA: 0x0010B88C File Offset: 0x00109A8C
		// Note: this type is marked as 'beforefieldinit'.
		static SerializationBinder()
		{
			Il2CppClassPointerStore<SerializationBinder>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "SerializationBinder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializationBinder>.NativeClassPtr);
			SerializationBinder.NativeMethodInfoPtr_BindToName_Public_Virtual_New_Void_Type_byref_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationBinder>.NativeClassPtr, 100671772);
			SerializationBinder.NativeMethodInfoPtr_BindToType_Public_Abstract_Virtual_New_Type_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationBinder>.NativeClassPtr, 100671773);
			SerializationBinder.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationBinder>.NativeClassPtr, 100671774);
		}

		// Token: 0x06003697 RID: 13975 RVA: 0x0010B8F8 File Offset: 0x00109AF8
		[CallerCount(0)]
		public unsafe virtual void BindToName(Type serializedType, out string assemblyName, out string typeName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializedType);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializationBinder.NativeMethodInfoPtr_BindToName_Public_Virtual_New_Void_Type_byref_String_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			assemblyName = IL2CPP.Il2CppStringToManaged(intPtr);
			typeName = IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		// Token: 0x06003698 RID: 13976 RVA: 0x0010B97C File Offset: 0x00109B7C
		[CallerCount(0)]
		public unsafe virtual Type BindToType(string assemblyName, string typeName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(assemblyName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(typeName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializationBinder.NativeMethodInfoPtr_BindToType_Public_Abstract_Virtual_New_Type_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06003699 RID: 13977 RVA: 0x0010B9EC File Offset: 0x00109BEC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializationBinder()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializationBinder>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationBinder.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600369A RID: 13978 RVA: 0x00013677 File Offset: 0x00011877
		public SerializationBinder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002E04 RID: 11780
		private static readonly IntPtr NativeMethodInfoPtr_BindToName_Public_Virtual_New_Void_Type_byref_String_byref_String_0;

		// Token: 0x04002E05 RID: 11781
		private static readonly IntPtr NativeMethodInfoPtr_BindToType_Public_Abstract_Virtual_New_Type_String_String_0;

		// Token: 0x04002E06 RID: 11782
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
