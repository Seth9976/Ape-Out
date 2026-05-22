using System;
using System.Reflection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Unity.Collections
{
	// Token: 0x02000015 RID: 21
	[DefaultMember("Item")]
	[Serializable]
	public sealed class FixedList512Bytes<T> : ValueType where T : new()
	{
		// Token: 0x06000098 RID: 152 RVA: 0x00005FA4 File Offset: 0x000041A4
		// Note: this type is marked as 'beforefieldinit'.
		static FixedList512Bytes()
		{
			Il2CppClassPointerStore<FixedList512Bytes<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Unity.Collections.dll", "Unity.Collections", "FixedList512Bytes`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FixedList512Bytes<T>>.NativeClassPtr);
			FixedList512Bytes<T>.NativeFieldInfoPtr_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FixedList512Bytes<T>>.NativeClassPtr, "length");
			FixedList512Bytes<T>.NativeFieldInfoPtr_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FixedList512Bytes<T>>.NativeClassPtr, "buffer");
			FixedList512Bytes<T>.NativeMethodInfoPtr_get_Length_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixedList512Bytes<T>>.NativeClassPtr, 100663441);
			FixedList512Bytes<T>.NativeMethodInfoPtr_get_LengthInBytes_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixedList512Bytes<T>>.NativeClassPtr, 100663442);
			FixedList512Bytes<T>.NativeMethodInfoPtr_get_Buffer_Internal_get_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixedList512Bytes<T>>.NativeClassPtr, 100663443);
			FixedList512Bytes<T>.NativeMethodInfoPtr_ElementAt_Public_Virtual_Final_New_byref_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixedList512Bytes<T>>.NativeClassPtr, 100663444);
			FixedList512Bytes<T>.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixedList512Bytes<T>>.NativeClassPtr, 100663445);
			FixedList512Bytes<T>.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_FixedList32Bytes_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixedList512Bytes<T>>.NativeClassPtr, 100663446);
			FixedList512Bytes<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_FixedList32Bytes_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixedList512Bytes<T>>.NativeClassPtr, 100663447);
			FixedList512Bytes<T>.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_FixedList64Bytes_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixedList512Bytes<T>>.NativeClassPtr, 100663448);
			FixedList512Bytes<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_FixedList64Bytes_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixedList512Bytes<T>>.NativeClassPtr, 100663449);
			FixedList512Bytes<T>.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_FixedList128Bytes_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixedList512Bytes<T>>.NativeClassPtr, 100663450);
			FixedList512Bytes<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_FixedList128Bytes_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixedList512Bytes<T>>.NativeClassPtr, 100663451);
			FixedList512Bytes<T>.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_FixedList512Bytes_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixedList512Bytes<T>>.NativeClassPtr, 100663452);
			FixedList512Bytes<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_FixedList512Bytes_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixedList512Bytes<T>>.NativeClassPtr, 100663453);
			FixedList512Bytes<T>.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_FixedList4096Bytes_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixedList512Bytes<T>>.NativeClassPtr, 100663454);
			FixedList512Bytes<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_FixedList4096Bytes_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixedList512Bytes<T>>.NativeClassPtr, 100663455);
			FixedList512Bytes<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixedList512Bytes<T>>.NativeClassPtr, 100663456);
			FixedList512Bytes<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixedList512Bytes<T>>.NativeClassPtr, 100663457);
			FixedList512Bytes<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixedList512Bytes<T>>.NativeClassPtr, 100663458);
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000099 RID: 153 RVA: 0x000061A0 File Offset: 0x000043A0
		public unsafe int Length
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FixedList512Bytes<T>.NativeMethodInfoPtr_get_Length_Public_Virtual_Final_New_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600009A RID: 154 RVA: 0x000061E4 File Offset: 0x000043E4
		public unsafe int LengthInBytes
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FixedList512Bytes<T>.NativeMethodInfoPtr_get_LengthInBytes_Internal_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600009B RID: 155 RVA: 0x00006228 File Offset: 0x00004428
		public unsafe byte* Buffer
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FixedList512Bytes<T>.NativeMethodInfoPtr_get_Buffer_Internal_get_ptr_Byte_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return intPtr;
			}
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00006260 File Offset: 0x00004460
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ref T ElementAt(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FixedList512Bytes<T>.NativeMethodInfoPtr_ElementAt_Public_Virtual_Final_New_byref_T_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return intPtr;
			}
		}

		// Token: 0x0600009D RID: 157 RVA: 0x000062A4 File Offset: 0x000044A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FixedList512Bytes<T>.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600009E RID: 158 RVA: 0x000062E8 File Offset: 0x000044E8
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 440223, RefRangeEnd = 440243, XrefRangeStart = 440223, XrefRangeEnd = 440243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(FixedList32Bytes<T> other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FixedList512Bytes<T>.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_FixedList32Bytes_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00006340 File Offset: 0x00004540
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(FixedList32Bytes<T> other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FixedList512Bytes<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_FixedList32Bytes_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00006398 File Offset: 0x00004598
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 440223, RefRangeEnd = 440243, XrefRangeStart = 440223, XrefRangeEnd = 440243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(FixedList64Bytes<T> other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FixedList512Bytes<T>.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_FixedList64Bytes_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x000063F0 File Offset: 0x000045F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(FixedList64Bytes<T> other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FixedList512Bytes<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_FixedList64Bytes_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00006448 File Offset: 0x00004648
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 440223, RefRangeEnd = 440243, XrefRangeStart = 440223, XrefRangeEnd = 440243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(FixedList128Bytes<T> other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FixedList512Bytes<T>.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_FixedList128Bytes_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x000064A0 File Offset: 0x000046A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440338, XrefRangeEnd = 440340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(FixedList128Bytes<T> other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FixedList512Bytes<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_FixedList128Bytes_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x000064F8 File Offset: 0x000046F8
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 440223, RefRangeEnd = 440243, XrefRangeStart = 440223, XrefRangeEnd = 440243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(FixedList512Bytes<T> other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FixedList512Bytes<T>.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_FixedList512Bytes_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00006550 File Offset: 0x00004750
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(FixedList512Bytes<T> other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FixedList512Bytes<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_FixedList512Bytes_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x000065A8 File Offset: 0x000047A8
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 440223, RefRangeEnd = 440243, XrefRangeStart = 440223, XrefRangeEnd = 440243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(FixedList4096Bytes<T> other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FixedList512Bytes<T>.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_FixedList4096Bytes_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00006600 File Offset: 0x00004800
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(FixedList4096Bytes<T> other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FixedList512Bytes<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_FixedList4096Bytes_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00006658 File Offset: 0x00004858
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440340, XrefRangeEnd = 440356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FixedList512Bytes<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x000066AC File Offset: 0x000048AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440356, XrefRangeEnd = 440361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FixedList512Bytes<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060000AA RID: 170 RVA: 0x000066F0 File Offset: 0x000048F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440361, XrefRangeEnd = 440366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator<T> System_Collections_Generic_IEnumerable_T__GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FixedList512Bytes<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<T>>(intPtr3) : null;
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00002390 File Offset: 0x00000590
		public FixedList512Bytes(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00002399 File Offset: 0x00000599
		public FixedList512Bytes()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FixedList512Bytes<T>>.NativeClassPtr))
		{
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x060000AD RID: 173 RVA: 0x00006734 File Offset: 0x00004934
		// (set) Token: 0x060000AE RID: 174 RVA: 0x000023AB File Offset: 0x000005AB
		public unsafe ushort length
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FixedList512Bytes<T>.NativeFieldInfoPtr_length);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FixedList512Bytes<T>.NativeFieldInfoPtr_length)) = value;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x060000AF RID: 175 RVA: 0x0000675C File Offset: 0x0000495C
		// (set) Token: 0x060000B0 RID: 176 RVA: 0x000023C6 File Offset: 0x000005C6
		public unsafe FixedBytes510 buffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FixedList512Bytes<T>.NativeFieldInfoPtr_buffer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FixedList512Bytes<T>.NativeFieldInfoPtr_buffer)) = value;
			}
		}

		// Token: 0x04000096 RID: 150
		private static readonly IntPtr NativeFieldInfoPtr_length;

		// Token: 0x04000097 RID: 151
		private static readonly IntPtr NativeFieldInfoPtr_buffer;

		// Token: 0x04000098 RID: 152
		private static readonly IntPtr NativeMethodInfoPtr_get_Length_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04000099 RID: 153
		private static readonly IntPtr NativeMethodInfoPtr_get_LengthInBytes_Internal_get_Int32_0;

		// Token: 0x0400009A RID: 154
		private static readonly IntPtr NativeMethodInfoPtr_get_Buffer_Internal_get_ptr_Byte_0;

		// Token: 0x0400009B RID: 155
		private static readonly IntPtr NativeMethodInfoPtr_ElementAt_Public_Virtual_Final_New_byref_T_Int32_0;

		// Token: 0x0400009C RID: 156
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400009D RID: 157
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_FixedList32Bytes_1_T_0;

		// Token: 0x0400009E RID: 158
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_FixedList32Bytes_1_T_0;

		// Token: 0x0400009F RID: 159
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_FixedList64Bytes_1_T_0;

		// Token: 0x040000A0 RID: 160
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_FixedList64Bytes_1_T_0;

		// Token: 0x040000A1 RID: 161
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_FixedList128Bytes_1_T_0;

		// Token: 0x040000A2 RID: 162
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_FixedList128Bytes_1_T_0;

		// Token: 0x040000A3 RID: 163
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_FixedList512Bytes_1_T_0;

		// Token: 0x040000A4 RID: 164
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_FixedList512Bytes_1_T_0;

		// Token: 0x040000A5 RID: 165
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_FixedList4096Bytes_1_T_0;

		// Token: 0x040000A6 RID: 166
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_FixedList4096Bytes_1_T_0;

		// Token: 0x040000A7 RID: 167
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040000A8 RID: 168
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x040000A9 RID: 169
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0;
	}
}
