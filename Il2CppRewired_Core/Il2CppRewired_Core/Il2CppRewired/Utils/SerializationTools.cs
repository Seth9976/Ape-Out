using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using Il2CppSystem.Xml;

namespace Il2CppRewired.Utils
{
	// Token: 0x020001F6 RID: 502
	public static class SerializationTools : Object
	{
		// Token: 0x06003365 RID: 13157 RVA: 0x00100AAC File Offset: 0x000FECAC
		// Note: this type is marked as 'beforefieldinit'.
		static SerializationTools()
		{
			Il2CppClassPointerStore<SerializationTools>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Utils", "SerializationTools");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializationTools>.NativeClassPtr);
			SerializationTools.NativeMethodInfoPtr_SerializeObjectToXmlString_Public_Static_String_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationTools>.NativeClassPtr, 100676249);
			SerializationTools.NativeMethodInfoPtr_WriteXmlElement_Public_Static_Void_XmlWriter_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationTools>.NativeClassPtr, 100676250);
			SerializationTools.NativeMethodInfoPtr_WriteXmlElement_Public_Static_Void_XmlWriter_String_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationTools>.NativeClassPtr, 100676251);
			SerializationTools.NativeMethodInfoPtr_vAohRxJIJQOLxtyeNsKmrPHeCfUb_Private_Static_Void_XmlWriter_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationTools>.NativeClassPtr, 100676252);
			SerializationTools.NativeMethodInfoPtr_ReadXmlElement_Public_Static_String_XmlReader_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationTools>.NativeClassPtr, 100676253);
			SerializationTools.NativeMethodInfoPtr_ReadXmlElement_Public_Static_T_XmlReader_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationTools>.NativeClassPtr, 100676254);
			SerializationTools.NativeMethodInfoPtr_TryReadXmlElement_Public_Static_Boolean_XmlReader_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationTools>.NativeClassPtr, 100676255);
			SerializationTools.NativeMethodInfoPtr_TryReadXmlElement_Public_Static_Boolean_XmlReader_String_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationTools>.NativeClassPtr, 100676256);
			SerializationTools.NativeMethodInfoPtr_TryReadXmlElement_Public_Static_Boolean_XmlReader_String_byref_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationTools>.NativeClassPtr, 100676257);
			SerializationTools.NativeMethodInfoPtr_TryReadXmlStartElement_Public_Static_Boolean_XmlReader_String_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationTools>.NativeClassPtr, 100676258);
			SerializationTools.NativeMethodInfoPtr_TryReadXmlEndElement_Public_Static_Boolean_XmlReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationTools>.NativeClassPtr, 100676259);
			SerializationTools.NativeMethodInfoPtr_CleanInvalidXmlChars_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationTools>.NativeClassPtr, 100676260);
		}

		// Token: 0x06003366 RID: 13158 RVA: 0x00100BCC File Offset: 0x000FEDCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339236, XrefRangeEnd = 339256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string SerializeObjectToXmlString<T>(T obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t = obj;
					if (!(t is string))
					{
						ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
						if ((ref ptr3) != null)
						{
							ptr4 = ref ptr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
							{
								ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
							}
						}
					}
					else
					{
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
					}
				}
				else
				{
					ptr4 = ref obj;
				}
				*ptr2 = ref ptr4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationTools.MethodInfoStoreGeneric_SerializeObjectToXmlString_Public_Static_String_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003367 RID: 13159 RVA: 0x00100C54 File Offset: 0x000FEE54
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 339280, RefRangeEnd = 339287, XrefRangeStart = 339256, XrefRangeEnd = 339280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteXmlElement(XmlWriter writer, string name, Object value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationTools.NativeMethodInfoPtr_WriteXmlElement_Public_Static_Void_XmlWriter_String_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003368 RID: 13160 RVA: 0x00100CB0 File Offset: 0x000FEEB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339287, XrefRangeEnd = 339295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteXmlElement<T>(XmlWriter writer, string name, T value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr* ptr2 = ptr + checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			ref T ptr4;
			if (!typeof(T).IsValueType)
			{
				T t = value;
				if (!(t is string))
				{
					ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					if ((ref ptr3) != null)
					{
						ptr4 = ref ptr3;
						if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
						{
							ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
						}
					}
				}
				else
				{
					ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
				}
			}
			else
			{
				ptr4 = ref value;
			}
			*ptr2 = ref ptr4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationTools.MethodInfoStoreGeneric_WriteXmlElement_Public_Static_Void_XmlWriter_String_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003369 RID: 13161 RVA: 0x00100D58 File Offset: 0x000FEF58
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 339607, RefRangeEnd = 339609, XrefRangeStart = 339295, XrefRangeEnd = 339607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void vAohRxJIJQOLxtyeNsKmrPHeCfUb(XmlWriter A_0, Object A_1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_1);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationTools.NativeMethodInfoPtr_vAohRxJIJQOLxtyeNsKmrPHeCfUb_Private_Static_Void_XmlWriter_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600336A RID: 13162 RVA: 0x00100DA0 File Offset: 0x000FEFA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339609, XrefRangeEnd = 339611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ReadXmlElement(XmlReader reader, string name)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationTools.NativeMethodInfoPtr_ReadXmlElement_Public_Static_String_XmlReader_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600336B RID: 13163 RVA: 0x00100DF0 File Offset: 0x000FEFF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339611, XrefRangeEnd = 339775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T ReadXmlElement<T>(XmlReader reader, string name)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationTools.MethodInfoStoreGeneric_ReadXmlElement_Public_Static_T_XmlReader_String_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x0600336C RID: 13164 RVA: 0x00100E40 File Offset: 0x000FF040
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 339777, RefRangeEnd = 339778, XrefRangeStart = 339775, XrefRangeEnd = 339777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryReadXmlElement(XmlReader reader, string name, out string outValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SerializationTools.NativeMethodInfoPtr_TryReadXmlElement_Public_Static_Boolean_XmlReader_String_byref_String_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			outValue = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600336D RID: 13165 RVA: 0x00100EB0 File Offset: 0x000FF0B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339778, XrefRangeEnd = 340021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryReadXmlElement<T>(XmlReader reader, string name, out T outValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			IntPtr intPtr2;
			if (!typeof(T).IsValueType)
			{
				intPtr = 0;
				intPtr2 = &intPtr;
			}
			else
			{
				intPtr2 = ref outValue;
			}
			ptr2 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(SerializationTools.MethodInfoStoreGeneric_TryReadXmlElement_Public_Static_Boolean_XmlReader_String_byref_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(T).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				outValue = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x0600336E RID: 13166 RVA: 0x00100F54 File Offset: 0x000FF154
		[CallerCount(0)]
		public unsafe static bool TryReadXmlElement<T>(XmlReader reader, string name, out T outValue, T defaultValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			IntPtr intPtr2;
			if (!typeof(T).IsValueType)
			{
				intPtr = 0;
				intPtr2 = &intPtr;
			}
			else
			{
				intPtr2 = ref outValue;
			}
			ptr2 = intPtr2;
			IntPtr* ptr3 = ptr + checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			ref T ptr5;
			if (!typeof(T).IsValueType)
			{
				T t = defaultValue;
				if (!(t is string))
				{
					ref T ptr4 = (ptr5 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					if ((ref ptr4) != null)
					{
						ptr5 = ref ptr4;
						if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr4)))
						{
							ptr5 = IL2CPP.il2cpp_object_unbox(ref ptr4);
						}
					}
				}
				else
				{
					ptr5 = IL2CPP.ManagedStringToIl2Cpp(t as string);
				}
			}
			else
			{
				ptr5 = ref defaultValue;
			}
			*ptr3 = ref ptr5;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(SerializationTools.MethodInfoStoreGeneric_TryReadXmlElement_Public_Static_Boolean_XmlReader_String_byref_T_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(T).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				outValue = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x0600336F RID: 13167 RVA: 0x00101054 File Offset: 0x000FF254
		[CallerCount(0)]
		public unsafe static bool TryReadXmlStartElement(XmlReader reader, string name, out bool isEmpty)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &isEmpty;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationTools.NativeMethodInfoPtr_TryReadXmlStartElement_Public_Static_Boolean_XmlReader_String_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003370 RID: 13168 RVA: 0x001010B8 File Offset: 0x000FF2B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340021, XrefRangeEnd = 340022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryReadXmlEndElement(XmlReader reader)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationTools.NativeMethodInfoPtr_TryReadXmlEndElement_Public_Static_Boolean_XmlReader_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003371 RID: 13169 RVA: 0x001010FC File Offset: 0x000FF2FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 340033, RefRangeEnd = 340034, XrefRangeStart = 340022, XrefRangeEnd = 340033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string CleanInvalidXmlChars(string text)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationTools.NativeMethodInfoPtr_CleanInvalidXmlChars_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003372 RID: 13170 RVA: 0x00011E40 File Offset: 0x00010040
		public SerializationTools(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002BD6 RID: 11222
		private static readonly IntPtr NativeMethodInfoPtr_SerializeObjectToXmlString_Public_Static_String_T_0;

		// Token: 0x04002BD7 RID: 11223
		private static readonly IntPtr NativeMethodInfoPtr_WriteXmlElement_Public_Static_Void_XmlWriter_String_Object_0;

		// Token: 0x04002BD8 RID: 11224
		private static readonly IntPtr NativeMethodInfoPtr_WriteXmlElement_Public_Static_Void_XmlWriter_String_T_0;

		// Token: 0x04002BD9 RID: 11225
		private static readonly IntPtr NativeMethodInfoPtr_vAohRxJIJQOLxtyeNsKmrPHeCfUb_Private_Static_Void_XmlWriter_Object_0;

		// Token: 0x04002BDA RID: 11226
		private static readonly IntPtr NativeMethodInfoPtr_ReadXmlElement_Public_Static_String_XmlReader_String_0;

		// Token: 0x04002BDB RID: 11227
		private static readonly IntPtr NativeMethodInfoPtr_ReadXmlElement_Public_Static_T_XmlReader_String_0;

		// Token: 0x04002BDC RID: 11228
		private static readonly IntPtr NativeMethodInfoPtr_TryReadXmlElement_Public_Static_Boolean_XmlReader_String_byref_String_0;

		// Token: 0x04002BDD RID: 11229
		private static readonly IntPtr NativeMethodInfoPtr_TryReadXmlElement_Public_Static_Boolean_XmlReader_String_byref_T_0;

		// Token: 0x04002BDE RID: 11230
		private static readonly IntPtr NativeMethodInfoPtr_TryReadXmlElement_Public_Static_Boolean_XmlReader_String_byref_T_T_0;

		// Token: 0x04002BDF RID: 11231
		private static readonly IntPtr NativeMethodInfoPtr_TryReadXmlStartElement_Public_Static_Boolean_XmlReader_String_byref_Boolean_0;

		// Token: 0x04002BE0 RID: 11232
		private static readonly IntPtr NativeMethodInfoPtr_TryReadXmlEndElement_Public_Static_Boolean_XmlReader_0;

		// Token: 0x04002BE1 RID: 11233
		private static readonly IntPtr NativeMethodInfoPtr_CleanInvalidXmlChars_Public_Static_String_String_0;

		// Token: 0x02000453 RID: 1107
		private sealed class MethodInfoStoreGeneric_SerializeObjectToXmlString_Public_Static_String_T_0<T>
		{
			// Token: 0x040043A1 RID: 17313
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SerializationTools.NativeMethodInfoPtr_SerializeObjectToXmlString_Public_Static_String_T_0, Il2CppClassPointerStore<SerializationTools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000454 RID: 1108
		private sealed class MethodInfoStoreGeneric_WriteXmlElement_Public_Static_Void_XmlWriter_String_T_0<T>
		{
			// Token: 0x040043A2 RID: 17314
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SerializationTools.NativeMethodInfoPtr_WriteXmlElement_Public_Static_Void_XmlWriter_String_T_0, Il2CppClassPointerStore<SerializationTools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000455 RID: 1109
		private sealed class MethodInfoStoreGeneric_ReadXmlElement_Public_Static_T_XmlReader_String_0<T>
		{
			// Token: 0x040043A3 RID: 17315
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SerializationTools.NativeMethodInfoPtr_ReadXmlElement_Public_Static_T_XmlReader_String_0, Il2CppClassPointerStore<SerializationTools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000456 RID: 1110
		private sealed class MethodInfoStoreGeneric_TryReadXmlElement_Public_Static_Boolean_XmlReader_String_byref_T_0<T>
		{
			// Token: 0x040043A4 RID: 17316
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SerializationTools.NativeMethodInfoPtr_TryReadXmlElement_Public_Static_Boolean_XmlReader_String_byref_T_0, Il2CppClassPointerStore<SerializationTools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000457 RID: 1111
		private sealed class MethodInfoStoreGeneric_TryReadXmlElement_Public_Static_Boolean_XmlReader_String_byref_T_T_0<T>
		{
			// Token: 0x040043A5 RID: 17317
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SerializationTools.NativeMethodInfoPtr_TryReadXmlElement_Public_Static_Boolean_XmlReader_String_byref_T_T_0, Il2CppClassPointerStore<SerializationTools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
