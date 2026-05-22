using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000024 RID: 36
	[Serializable]
	public class SerializableObjectDictionary<TKey, TValue> : AbstractSerializableDictionary<TKey, TValue> where TValue : global::UnityEngine.Object
	{
		// Token: 0x0600046E RID: 1134 RVA: 0x00040ED0 File Offset: 0x0003F0D0
		// Note: this type is marked as 'beforefieldinit'.
		static SerializableObjectDictionary()
		{
			Il2CppClassPointerStore<SerializableObjectDictionary<TKey, TValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SerializableObjectDictionary`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializableObjectDictionary<TKey, TValue>>.NativeClassPtr);
			SerializableObjectDictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableObjectDictionary<TKey, TValue>>.NativeClassPtr, 100663637);
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x00040F64 File Offset: 0x0003F164
		[CallerCount(0)]
		public unsafe SerializableObjectDictionary(string keyName = "Key", string valueName = "Value", string newKeyName = "New Key")
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializableObjectDictionary<TKey, TValue>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(keyName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(valueName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(newKeyName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableObjectDictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x00004D31 File Offset: 0x00002F31
		public SerializableObjectDictionary(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400029B RID: 667
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0;
	}
}
