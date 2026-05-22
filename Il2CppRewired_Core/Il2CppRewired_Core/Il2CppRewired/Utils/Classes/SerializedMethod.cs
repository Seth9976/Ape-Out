using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppRewired.Utils.Classes.Data;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppRewired.Utils.Classes
{
	// Token: 0x020000A2 RID: 162
	[Serializable]
	public class SerializedMethod : ScriptableObject
	{
		// Token: 0x0600142D RID: 5165 RVA: 0x00078A20 File Offset: 0x00076C20
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedMethod()
		{
			Il2CppClassPointerStore<SerializedMethod>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Utils.Classes", "SerializedMethod");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedMethod>.NativeClassPtr);
			SerializedMethod.NativeFieldInfoPtr_SYmonihLLqLXptGjYaOWmazCQPT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedMethod>.NativeClassPtr, "SYmonihLLqLXptGjYaOWmazCQPT");
			SerializedMethod.NativeFieldInfoPtr_rFavnSExmALFPXknHrCvAfirYCX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedMethod>.NativeClassPtr, "rFavnSExmALFPXknHrCvAfirYCX");
			SerializedMethod.NativeFieldInfoPtr__data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedMethod>.NativeClassPtr, "_data");
			SerializedMethod.NativeFieldInfoPtr__result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedMethod>.NativeClassPtr, "_result");
			SerializedMethod.NativeFieldInfoPtr__resultIsValid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedMethod>.NativeClassPtr, "_resultIsValid");
			SerializedMethod.NativeMethodInfoPtr_get_ResultType_Internal_Abstract_Virtual_New_get_DataType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedMethod>.NativeClassPtr, 100666711);
			SerializedMethod.NativeMethodInfoPtr_get_DataCount_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedMethod>.NativeClassPtr, 100666712);
			SerializedMethod.NativeMethodInfoPtr_get_Result_Internal_get_TypeWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedMethod>.NativeClassPtr, 100666713);
			SerializedMethod.NativeMethodInfoPtr_get_ResultIsValid_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedMethod>.NativeClassPtr, 100666714);
			SerializedMethod.NativeMethodInfoPtr_GetData_Internal_TypeWrapper_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedMethod>.NativeClassPtr, 100666715);
			SerializedMethod.NativeMethodInfoPtr_AddData_Internal_Void_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedMethod>.NativeClassPtr, 100666716);
			SerializedMethod.NativeMethodInfoPtr_AddData_Internal_Void_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedMethod>.NativeClassPtr, 100666717);
			SerializedMethod.NativeMethodInfoPtr_AddData_Internal_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedMethod>.NativeClassPtr, 100666718);
			SerializedMethod.NativeMethodInfoPtr_AddData_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedMethod>.NativeClassPtr, 100666719);
			SerializedMethod.NativeMethodInfoPtr_AddData_Internal_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedMethod>.NativeClassPtr, 100666720);
			SerializedMethod.NativeMethodInfoPtr_AddData_Internal_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedMethod>.NativeClassPtr, 100666721);
			SerializedMethod.NativeMethodInfoPtr_AddData_Internal_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedMethod>.NativeClassPtr, 100666722);
			SerializedMethod.NativeMethodInfoPtr_AddData_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedMethod>.NativeClassPtr, 100666723);
			SerializedMethod.NativeMethodInfoPtr_AddData_Internal_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedMethod>.NativeClassPtr, 100666724);
			SerializedMethod.NativeMethodInfoPtr_AddData_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedMethod>.NativeClassPtr, 100666725);
			SerializedMethod.NativeMethodInfoPtr_AddData_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedMethod>.NativeClassPtr, 100666726);
			SerializedMethod.NativeMethodInfoPtr_AddData_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedMethod>.NativeClassPtr, 100666727);
			SerializedMethod.NativeMethodInfoPtr_AddData_Internal_Void_TypeWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedMethod>.NativeClassPtr, 100666728);
			SerializedMethod.NativeMethodInfoPtr_ClearData_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedMethod>.NativeClassPtr, 100666729);
			SerializedMethod.NativeMethodInfoPtr_ClearResult_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedMethod>.NativeClassPtr, 100666730);
			SerializedMethod.NativeMethodInfoPtr_Process_Internal_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedMethod>.NativeClassPtr, 100666731);
			SerializedMethod.NativeMethodInfoPtr_yxMzoEuymkPbNRqpIEQpvUZkARy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedMethod>.NativeClassPtr, 100666732);
			SerializedMethod.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedMethod>.NativeClassPtr, 100666733);
		}

		// Token: 0x1700071B RID: 1819
		// (get) Token: 0x0600142E RID: 5166 RVA: 0x00078C80 File Offset: 0x00076E80
		public unsafe virtual TypeWrapper.DataType ResultType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedMethod.NativeMethodInfoPtr_get_ResultType_Internal_Abstract_Virtual_New_get_DataType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700071C RID: 1820
		// (get) Token: 0x0600142F RID: 5167 RVA: 0x00078CC8 File Offset: 0x00076EC8
		public unsafe int DataCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265259, XrefRangeEnd = 265260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedMethod.NativeMethodInfoPtr_get_DataCount_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700071D RID: 1821
		// (get) Token: 0x06001430 RID: 5168 RVA: 0x00078D04 File Offset: 0x00076F04
		public unsafe TypeWrapper Result
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedMethod.NativeMethodInfoPtr_get_Result_Internal_get_TypeWrapper_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new TypeWrapper(intPtr);
			}
		}

		// Token: 0x1700071E RID: 1822
		// (get) Token: 0x06001431 RID: 5169 RVA: 0x00078D3C File Offset: 0x00076F3C
		public unsafe bool ResultIsValid
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedMethod.NativeMethodInfoPtr_get_ResultIsValid_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001432 RID: 5170 RVA: 0x00078D78 File Offset: 0x00076F78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265260, XrefRangeEnd = 265262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TypeWrapper GetData(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedMethod.NativeMethodInfoPtr_GetData_Internal_TypeWrapper_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new TypeWrapper(intPtr);
			}
		}

		// Token: 0x06001433 RID: 5171 RVA: 0x00078DBC File Offset: 0x00076FBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265262, XrefRangeEnd = 265266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddData(byte item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref item;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedMethod.NativeMethodInfoPtr_AddData_Internal_Void_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001434 RID: 5172 RVA: 0x00078DFC File Offset: 0x00076FFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265266, XrefRangeEnd = 265270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddData(sbyte item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref item;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedMethod.NativeMethodInfoPtr_AddData_Internal_Void_SByte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001435 RID: 5173 RVA: 0x00078E3C File Offset: 0x0007703C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265270, XrefRangeEnd = 265274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddData(char item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref item;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedMethod.NativeMethodInfoPtr_AddData_Internal_Void_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001436 RID: 5174 RVA: 0x00078E7C File Offset: 0x0007707C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265274, XrefRangeEnd = 265278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddData(int item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref item;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedMethod.NativeMethodInfoPtr_AddData_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001437 RID: 5175 RVA: 0x00078EBC File Offset: 0x000770BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265278, XrefRangeEnd = 265282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddData(uint item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref item;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedMethod.NativeMethodInfoPtr_AddData_Internal_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001438 RID: 5176 RVA: 0x00078EFC File Offset: 0x000770FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265282, XrefRangeEnd = 265286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddData(long item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref item;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedMethod.NativeMethodInfoPtr_AddData_Internal_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001439 RID: 5177 RVA: 0x00078F3C File Offset: 0x0007713C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265286, XrefRangeEnd = 265290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddData(ulong item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref item;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedMethod.NativeMethodInfoPtr_AddData_Internal_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600143A RID: 5178 RVA: 0x00078F7C File Offset: 0x0007717C
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 265294, RefRangeEnd = 265303, XrefRangeStart = 265290, XrefRangeEnd = 265294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddData(float item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref item;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedMethod.NativeMethodInfoPtr_AddData_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600143B RID: 5179 RVA: 0x00078FBC File Offset: 0x000771BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265303, XrefRangeEnd = 265307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddData(double item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref item;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedMethod.NativeMethodInfoPtr_AddData_Internal_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600143C RID: 5180 RVA: 0x00078FFC File Offset: 0x000771FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265307, XrefRangeEnd = 265311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddData(bool item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref item;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedMethod.NativeMethodInfoPtr_AddData_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600143D RID: 5181 RVA: 0x0007903C File Offset: 0x0007723C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265311, XrefRangeEnd = 265315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddData(string item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedMethod.NativeMethodInfoPtr_AddData_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600143E RID: 5182 RVA: 0x00079080 File Offset: 0x00077280
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265315, XrefRangeEnd = 265319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddData(global::Il2CppSystem.Object item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedMethod.NativeMethodInfoPtr_AddData_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600143F RID: 5183 RVA: 0x000790C4 File Offset: 0x000772C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265319, XrefRangeEnd = 265322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddData(TypeWrapper item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(item));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedMethod.NativeMethodInfoPtr_AddData_Internal_Void_TypeWrapper_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001440 RID: 5184 RVA: 0x0007910C File Offset: 0x0007730C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265322, XrefRangeEnd = 265324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedMethod.NativeMethodInfoPtr_ClearData_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001441 RID: 5185 RVA: 0x00079140 File Offset: 0x00077340
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265324, XrefRangeEnd = 265325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearResult()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedMethod.NativeMethodInfoPtr_ClearResult_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001442 RID: 5186 RVA: 0x00079174 File Offset: 0x00077374
		[CallerCount(0)]
		public unsafe virtual bool Process()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedMethod.NativeMethodInfoPtr_Process_Internal_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001443 RID: 5187 RVA: 0x000791BC File Offset: 0x000773BC
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 265333, RefRangeEnd = 265346, XrefRangeStart = 265325, XrefRangeEnd = 265333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void yxMzoEuymkPbNRqpIEQpvUZkARy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedMethod.NativeMethodInfoPtr_yxMzoEuymkPbNRqpIEQpvUZkARy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001444 RID: 5188 RVA: 0x000791F0 File Offset: 0x000773F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedMethod()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedMethod>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedMethod.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001445 RID: 5189 RVA: 0x00008C95 File Offset: 0x00006E95
		public SerializedMethod(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000716 RID: 1814
		// (get) Token: 0x06001446 RID: 5190 RVA: 0x0007922C File Offset: 0x0007742C
		// (set) Token: 0x06001447 RID: 5191 RVA: 0x00008C9E File Offset: 0x00006E9E
		public unsafe static int SYmonihLLqLXptGjYaOWmazCQPT
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SerializedMethod.NativeFieldInfoPtr_SYmonihLLqLXptGjYaOWmazCQPT, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SerializedMethod.NativeFieldInfoPtr_SYmonihLLqLXptGjYaOWmazCQPT, (void*)(&value));
			}
		}

		// Token: 0x17000717 RID: 1815
		// (get) Token: 0x06001448 RID: 5192 RVA: 0x00079248 File Offset: 0x00077448
		// (set) Token: 0x06001449 RID: 5193 RVA: 0x00008CAC File Offset: 0x00006EAC
		public unsafe bool rFavnSExmALFPXknHrCvAfirYCX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedMethod.NativeFieldInfoPtr_rFavnSExmALFPXknHrCvAfirYCX);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedMethod.NativeFieldInfoPtr_rFavnSExmALFPXknHrCvAfirYCX)) = value;
			}
		}

		// Token: 0x17000718 RID: 1816
		// (get) Token: 0x0600144A RID: 5194 RVA: 0x00079270 File Offset: 0x00077470
		// (set) Token: 0x0600144B RID: 5195 RVA: 0x00008CC7 File Offset: 0x00006EC7
		public unsafe List<TypeWrapper> _data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedMethod.NativeFieldInfoPtr__data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TypeWrapper>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedMethod.NativeFieldInfoPtr__data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000719 RID: 1817
		// (get) Token: 0x0600144C RID: 5196 RVA: 0x000792A0 File Offset: 0x000774A0
		// (set) Token: 0x0600144D RID: 5197 RVA: 0x00008CE6 File Offset: 0x00006EE6
		public TypeWrapper _result
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedMethod.NativeFieldInfoPtr__result);
				return new TypeWrapper(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TypeWrapper>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedMethod.NativeFieldInfoPtr__result), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TypeWrapper>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700071A RID: 1818
		// (get) Token: 0x0600144E RID: 5198 RVA: 0x000792D0 File Offset: 0x000774D0
		// (set) Token: 0x0600144F RID: 5199 RVA: 0x00008D14 File Offset: 0x00006F14
		public unsafe bool _resultIsValid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedMethod.NativeFieldInfoPtr__resultIsValid);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedMethod.NativeFieldInfoPtr__resultIsValid)) = value;
			}
		}

		// Token: 0x04001049 RID: 4169
		private static readonly IntPtr NativeFieldInfoPtr_SYmonihLLqLXptGjYaOWmazCQPT;

		// Token: 0x0400104A RID: 4170
		private static readonly IntPtr NativeFieldInfoPtr_rFavnSExmALFPXknHrCvAfirYCX;

		// Token: 0x0400104B RID: 4171
		private static readonly IntPtr NativeFieldInfoPtr__data;

		// Token: 0x0400104C RID: 4172
		private static readonly IntPtr NativeFieldInfoPtr__result;

		// Token: 0x0400104D RID: 4173
		private static readonly IntPtr NativeFieldInfoPtr__resultIsValid;

		// Token: 0x0400104E RID: 4174
		private static readonly IntPtr NativeMethodInfoPtr_get_ResultType_Internal_Abstract_Virtual_New_get_DataType_0;

		// Token: 0x0400104F RID: 4175
		private static readonly IntPtr NativeMethodInfoPtr_get_DataCount_Internal_get_Int32_0;

		// Token: 0x04001050 RID: 4176
		private static readonly IntPtr NativeMethodInfoPtr_get_Result_Internal_get_TypeWrapper_0;

		// Token: 0x04001051 RID: 4177
		private static readonly IntPtr NativeMethodInfoPtr_get_ResultIsValid_Internal_get_Boolean_0;

		// Token: 0x04001052 RID: 4178
		private static readonly IntPtr NativeMethodInfoPtr_GetData_Internal_TypeWrapper_Int32_0;

		// Token: 0x04001053 RID: 4179
		private static readonly IntPtr NativeMethodInfoPtr_AddData_Internal_Void_Byte_0;

		// Token: 0x04001054 RID: 4180
		private static readonly IntPtr NativeMethodInfoPtr_AddData_Internal_Void_SByte_0;

		// Token: 0x04001055 RID: 4181
		private static readonly IntPtr NativeMethodInfoPtr_AddData_Internal_Void_Char_0;

		// Token: 0x04001056 RID: 4182
		private static readonly IntPtr NativeMethodInfoPtr_AddData_Internal_Void_Int32_0;

		// Token: 0x04001057 RID: 4183
		private static readonly IntPtr NativeMethodInfoPtr_AddData_Internal_Void_UInt32_0;

		// Token: 0x04001058 RID: 4184
		private static readonly IntPtr NativeMethodInfoPtr_AddData_Internal_Void_Int64_0;

		// Token: 0x04001059 RID: 4185
		private static readonly IntPtr NativeMethodInfoPtr_AddData_Internal_Void_UInt64_0;

		// Token: 0x0400105A RID: 4186
		private static readonly IntPtr NativeMethodInfoPtr_AddData_Internal_Void_Single_0;

		// Token: 0x0400105B RID: 4187
		private static readonly IntPtr NativeMethodInfoPtr_AddData_Internal_Void_Double_0;

		// Token: 0x0400105C RID: 4188
		private static readonly IntPtr NativeMethodInfoPtr_AddData_Internal_Void_Boolean_0;

		// Token: 0x0400105D RID: 4189
		private static readonly IntPtr NativeMethodInfoPtr_AddData_Internal_Void_String_0;

		// Token: 0x0400105E RID: 4190
		private static readonly IntPtr NativeMethodInfoPtr_AddData_Internal_Void_Object_0;

		// Token: 0x0400105F RID: 4191
		private static readonly IntPtr NativeMethodInfoPtr_AddData_Internal_Void_TypeWrapper_0;

		// Token: 0x04001060 RID: 4192
		private static readonly IntPtr NativeMethodInfoPtr_ClearData_Internal_Void_0;

		// Token: 0x04001061 RID: 4193
		private static readonly IntPtr NativeMethodInfoPtr_ClearResult_Internal_Void_0;

		// Token: 0x04001062 RID: 4194
		private static readonly IntPtr NativeMethodInfoPtr_Process_Internal_Abstract_Virtual_New_Boolean_0;

		// Token: 0x04001063 RID: 4195
		private static readonly IntPtr NativeMethodInfoPtr_yxMzoEuymkPbNRqpIEQpvUZkARy_Private_Void_0;

		// Token: 0x04001064 RID: 4196
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
