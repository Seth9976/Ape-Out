using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000003 RID: 3
	public class MonoBehaviourSingleton<TSelfType> : MonoBehaviour where TSelfType : MonoBehaviour
	{
		// Token: 0x06000008 RID: 8 RVA: 0x0000DEEC File Offset: 0x0000C0EC
		// Note: this type is marked as 'beforefieldinit'.
		static MonoBehaviourSingleton()
		{
			Il2CppClassPointerStore<MonoBehaviourSingleton<TSelfType>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "MonoBehaviourSingleton`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSelfType>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoBehaviourSingleton<TSelfType>>.NativeClassPtr);
			MonoBehaviourSingleton<TSelfType>.NativeFieldInfoPtr_m_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBehaviourSingleton<TSelfType>>.NativeClassPtr, "m_Instance");
			MonoBehaviourSingleton<TSelfType>.NativeMethodInfoPtr_get_Instance_Public_Static_get_TSelfType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviourSingleton<TSelfType>>.NativeClassPtr, 100663302);
			MonoBehaviourSingleton<TSelfType>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviourSingleton<TSelfType>>.NativeClassPtr, 100663303);
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000009 RID: 9 RVA: 0x0000DF94 File Offset: 0x0000C194
		public unsafe static TSelfType Instance
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37, XrefRangeEnd = 133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBehaviourSingleton<TSelfType>.NativeMethodInfoPtr_get_Instance_Public_Static_get_TSelfType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TSelfType>(intPtr, false, true);
			}
		}

		// Token: 0x0600000A RID: 10 RVA: 0x0000DFC4 File Offset: 0x0000C1C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133, XrefRangeEnd = 136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoBehaviourSingleton()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoBehaviourSingleton<TSelfType>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBehaviourSingleton<TSelfType>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002059 File Offset: 0x00000259
		public MonoBehaviourSingleton(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600000C RID: 12 RVA: 0x0000E000 File Offset: 0x0000C200
		// (set) Token: 0x0600000D RID: 13 RVA: 0x0000E024 File Offset: 0x0000C224
		public unsafe static TSelfType m_Instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MonoBehaviourSingleton<TSelfType>.NativeFieldInfoPtr_m_Instance, (void*)(&intPtr));
				return IL2CPP.PointerToValueGeneric<TSelfType>(intPtr, false, false);
			}
			set
			{
				IntPtr nativeFieldInfoPtr_m_Instance = MonoBehaviourSingleton<TSelfType>.NativeFieldInfoPtr_m_Instance;
				ref TSelfType ptr2;
				if (!typeof(TSelfType).IsValueType)
				{
					TSelfType tselfType = value;
					if (!(tselfType is string))
					{
						ref TSelfType ptr = (ptr2 = IL2CPP.Il2CppObjectBaseToPtr(tselfType as Il2CppObjectBase));
						if ((ref ptr) != null)
						{
							ptr2 = ref ptr;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr)))
							{
								ptr2 = IL2CPP.il2cpp_object_unbox(ref ptr);
							}
						}
					}
					else
					{
						ptr2 = IL2CPP.ManagedStringToIl2Cpp(tselfType as string);
					}
				}
				else
				{
					ptr2 = ref value;
				}
				IL2CPP.il2cpp_field_static_set_value(nativeFieldInfoPtr_m_Instance, (void*)(&ptr2));
			}
		}

		// Token: 0x04000006 RID: 6
		private static readonly IntPtr NativeFieldInfoPtr_m_Instance;

		// Token: 0x04000007 RID: 7
		private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_TSelfType_0;

		// Token: 0x04000008 RID: 8
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
