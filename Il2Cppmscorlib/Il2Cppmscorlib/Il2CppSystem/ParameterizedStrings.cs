using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000136 RID: 310
	public static class ParameterizedStrings : Object
	{
		// Token: 0x060016A2 RID: 5794 RVA: 0x0008A7F4 File Offset: 0x000889F4
		// Note: this type is marked as 'beforefieldinit'.
		static ParameterizedStrings()
		{
			Il2CppClassPointerStore<ParameterizedStrings>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ParameterizedStrings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParameterizedStrings>.NativeClassPtr);
			ParameterizedStrings.NativeFieldInfoPtr__cachedStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParameterizedStrings>.NativeClassPtr, "_cachedStack");
			ParameterizedStrings.NativeMethodInfoPtr_Evaluate_Public_Static_String_String_Il2CppReferenceArray_1_FormatParam_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterizedStrings>.NativeClassPtr, 100667161);
			ParameterizedStrings.NativeMethodInfoPtr_EvaluateInternal_Private_Static_String_String_byref_Int32_Il2CppReferenceArray_1_FormatParam_LowLevelStack_byref_Il2CppReferenceArray_1_FormatParam_byref_Il2CppReferenceArray_1_FormatParam_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterizedStrings>.NativeClassPtr, 100667162);
			ParameterizedStrings.NativeMethodInfoPtr_AsBool_Private_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterizedStrings>.NativeClassPtr, 100667163);
			ParameterizedStrings.NativeMethodInfoPtr_AsInt_Private_Static_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterizedStrings>.NativeClassPtr, 100667164);
			ParameterizedStrings.NativeMethodInfoPtr_StringFromAsciiBytes_Private_Static_String_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterizedStrings>.NativeClassPtr, 100667165);
			ParameterizedStrings.NativeMethodInfoPtr_snprintf_Private_Static_Int32_ptr_Byte_IntPtr_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterizedStrings>.NativeClassPtr, 100667166);
			ParameterizedStrings.NativeMethodInfoPtr_snprintf_Private_Static_Int32_ptr_Byte_IntPtr_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterizedStrings>.NativeClassPtr, 100667167);
			ParameterizedStrings.NativeMethodInfoPtr_FormatPrintF_Private_Static_String_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterizedStrings>.NativeClassPtr, 100667168);
			ParameterizedStrings.NativeMethodInfoPtr_GetDynamicOrStaticVariables_Private_Static_Il2CppReferenceArray_1_FormatParam_Char_byref_Il2CppReferenceArray_1_FormatParam_byref_Il2CppReferenceArray_1_FormatParam_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterizedStrings>.NativeClassPtr, 100667169);
		}

		// Token: 0x060016A3 RID: 5795 RVA: 0x0008A8EC File Offset: 0x00088AEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 178205, RefRangeEnd = 178206, XrefRangeStart = 178191, XrefRangeEnd = 178205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Evaluate(string format, [Optional] Il2CppReferenceArray<ParameterizedStrings.FormatParam> args)
		{
			if (args == null)
			{
				args = new Il2CppStructArray<ParameterizedStrings.FormatParam>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterizedStrings.NativeMethodInfoPtr_Evaluate_Public_Static_String_String_Il2CppReferenceArray_1_FormatParam_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060016A4 RID: 5796 RVA: 0x0008A948 File Offset: 0x00088B48
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 178341, RefRangeEnd = 178344, XrefRangeStart = 178206, XrefRangeEnd = 178341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string EvaluateInternal(string format, ref int pos, Il2CppReferenceArray<ParameterizedStrings.FormatParam> args, ParameterizedStrings.LowLevelStack stack, ref Il2CppReferenceArray<ParameterizedStrings.FormatParam> dynamicVars, ref Il2CppReferenceArray<ParameterizedStrings.FormatParam> staticVars)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stack);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(dynamicVars);
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(staticVars);
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ParameterizedStrings.NativeMethodInfoPtr_EvaluateInternal_Private_Static_String_String_byref_Int32_Il2CppReferenceArray_1_FormatParam_LowLevelStack_byref_Il2CppReferenceArray_1_FormatParam_byref_Il2CppReferenceArray_1_FormatParam_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			dynamicVars = ((intPtr5 == 0) ? null : new Il2CppReferenceArray<ParameterizedStrings.FormatParam>(intPtr5));
			IntPtr intPtr6 = intPtr2;
			staticVars = ((intPtr6 == 0) ? null : new Il2CppReferenceArray<ParameterizedStrings.FormatParam>(intPtr6));
			return IL2CPP.Il2CppStringToManaged(intPtr3);
		}

		// Token: 0x060016A5 RID: 5797 RVA: 0x0008AA0C File Offset: 0x00088C0C
		[CallerCount(0)]
		public unsafe static bool AsBool(int i)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterizedStrings.NativeMethodInfoPtr_AsBool_Private_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060016A6 RID: 5798 RVA: 0x0008AA4C File Offset: 0x00088C4C
		[CallerCount(0)]
		public unsafe static int AsInt(bool b)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterizedStrings.NativeMethodInfoPtr_AsInt_Private_Static_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060016A7 RID: 5799 RVA: 0x0008AA8C File Offset: 0x00088C8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178344, XrefRangeEnd = 178353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string StringFromAsciiBytes(Il2CppStructArray<byte> buffer, int offset, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterizedStrings.NativeMethodInfoPtr_StringFromAsciiBytes_Private_Static_String_Il2CppStructArray_1_Byte_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060016A8 RID: 5800 RVA: 0x0008AAE4 File Offset: 0x00088CE4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 178356, RefRangeEnd = 178358, XrefRangeStart = 178353, XrefRangeEnd = 178356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int snprintf(byte* str, IntPtr size, string format, string arg1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = str;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(arg1);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterizedStrings.NativeMethodInfoPtr_snprintf_Private_Static_Int32_ptr_Byte_IntPtr_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060016A9 RID: 5801 RVA: 0x0008AB54 File Offset: 0x00088D54
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 178360, RefRangeEnd = 178362, XrefRangeStart = 178358, XrefRangeEnd = 178360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int snprintf(byte* str, IntPtr size, string format, int arg1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = str;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg1;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterizedStrings.NativeMethodInfoPtr_snprintf_Private_Static_Int32_ptr_Byte_IntPtr_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060016AA RID: 5802 RVA: 0x0008ABC0 File Offset: 0x00088DC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 178386, RefRangeEnd = 178387, XrefRangeStart = 178362, XrefRangeEnd = 178386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FormatPrintF(string format, Object arg)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterizedStrings.NativeMethodInfoPtr_FormatPrintF_Private_Static_String_String_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060016AB RID: 5803 RVA: 0x0008AC10 File Offset: 0x00088E10
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 178394, RefRangeEnd = 178396, XrefRangeStart = 178387, XrefRangeEnd = 178394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<ParameterizedStrings.FormatParam> GetDynamicOrStaticVariables(char c, ref Il2CppReferenceArray<ParameterizedStrings.FormatParam> dynamicVars, ref Il2CppReferenceArray<ParameterizedStrings.FormatParam> staticVars, out int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(dynamicVars);
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(staticVars);
			ptr3 = &intPtr2;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &index;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ParameterizedStrings.NativeMethodInfoPtr_GetDynamicOrStaticVariables_Private_Static_Il2CppReferenceArray_1_FormatParam_Char_byref_Il2CppReferenceArray_1_FormatParam_byref_Il2CppReferenceArray_1_FormatParam_byref_Int32_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			dynamicVars = ((intPtr5 == 0) ? null : new Il2CppReferenceArray<ParameterizedStrings.FormatParam>(intPtr5));
			IntPtr intPtr6 = intPtr2;
			staticVars = ((intPtr6 == 0) ? null : new Il2CppReferenceArray<ParameterizedStrings.FormatParam>(intPtr6));
			IntPtr intPtr7 = intPtr3;
			return (intPtr7 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ParameterizedStrings.FormatParam>>(intPtr7) : null;
		}

		// Token: 0x060016AC RID: 5804 RVA: 0x00007CFD File Offset: 0x00005EFD
		public static string Evaluate(string format, params ParameterizedStrings.FormatParam[] args)
		{
			return ParameterizedStrings.Evaluate(format, new Il2CppReferenceArray<ParameterizedStrings.FormatParam>(args));
		}

		// Token: 0x060016AD RID: 5805 RVA: 0x00007D0B File Offset: 0x00005F0B
		public ParameterizedStrings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x060016AE RID: 5806 RVA: 0x0008ACB0 File Offset: 0x00088EB0
		// (set) Token: 0x060016AF RID: 5807 RVA: 0x00007D14 File Offset: 0x00005F14
		public unsafe static ParameterizedStrings.LowLevelStack _cachedStack
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ParameterizedStrings.NativeFieldInfoPtr__cachedStack, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParameterizedStrings.LowLevelStack>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ParameterizedStrings.NativeFieldInfoPtr__cachedStack, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001333 RID: 4915
		private static readonly IntPtr NativeFieldInfoPtr__cachedStack;

		// Token: 0x04001334 RID: 4916
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Static_String_String_Il2CppReferenceArray_1_FormatParam_0;

		// Token: 0x04001335 RID: 4917
		private static readonly IntPtr NativeMethodInfoPtr_EvaluateInternal_Private_Static_String_String_byref_Int32_Il2CppReferenceArray_1_FormatParam_LowLevelStack_byref_Il2CppReferenceArray_1_FormatParam_byref_Il2CppReferenceArray_1_FormatParam_0;

		// Token: 0x04001336 RID: 4918
		private static readonly IntPtr NativeMethodInfoPtr_AsBool_Private_Static_Boolean_Int32_0;

		// Token: 0x04001337 RID: 4919
		private static readonly IntPtr NativeMethodInfoPtr_AsInt_Private_Static_Int32_Boolean_0;

		// Token: 0x04001338 RID: 4920
		private static readonly IntPtr NativeMethodInfoPtr_StringFromAsciiBytes_Private_Static_String_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04001339 RID: 4921
		private static readonly IntPtr NativeMethodInfoPtr_snprintf_Private_Static_Int32_ptr_Byte_IntPtr_String_String_0;

		// Token: 0x0400133A RID: 4922
		private static readonly IntPtr NativeMethodInfoPtr_snprintf_Private_Static_Int32_ptr_Byte_IntPtr_String_Int32_0;

		// Token: 0x0400133B RID: 4923
		private static readonly IntPtr NativeMethodInfoPtr_FormatPrintF_Private_Static_String_String_Object_0;

		// Token: 0x0400133C RID: 4924
		private static readonly IntPtr NativeMethodInfoPtr_GetDynamicOrStaticVariables_Private_Static_Il2CppReferenceArray_1_FormatParam_Char_byref_Il2CppReferenceArray_1_FormatParam_byref_Il2CppReferenceArray_1_FormatParam_byref_Int32_0;

		// Token: 0x020005AF RID: 1455
		public sealed class FormatParam : ValueType
		{
			// Token: 0x06005184 RID: 20868 RVA: 0x00171064 File Offset: 0x0016F264
			// Note: this type is marked as 'beforefieldinit'.
			static FormatParam()
			{
				Il2CppClassPointerStore<ParameterizedStrings.FormatParam>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParameterizedStrings>.NativeClassPtr, "FormatParam");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParameterizedStrings.FormatParam>.NativeClassPtr);
				ParameterizedStrings.FormatParam.NativeFieldInfoPtr__int32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParameterizedStrings.FormatParam>.NativeClassPtr, "_int32");
				ParameterizedStrings.FormatParam.NativeFieldInfoPtr__string = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParameterizedStrings.FormatParam>.NativeClassPtr, "_string");
				ParameterizedStrings.FormatParam.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterizedStrings.FormatParam>.NativeClassPtr, 100667170);
				ParameterizedStrings.FormatParam.NativeMethodInfoPtr__ctor_Private_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterizedStrings.FormatParam>.NativeClassPtr, 100667171);
				ParameterizedStrings.FormatParam.NativeMethodInfoPtr_op_Implicit_Public_Static_FormatParam_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterizedStrings.FormatParam>.NativeClassPtr, 100667172);
				ParameterizedStrings.FormatParam.NativeMethodInfoPtr_get_Int32_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterizedStrings.FormatParam>.NativeClassPtr, 100667173);
				ParameterizedStrings.FormatParam.NativeMethodInfoPtr_get_String_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterizedStrings.FormatParam>.NativeClassPtr, 100667174);
				ParameterizedStrings.FormatParam.NativeMethodInfoPtr_get_Object_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterizedStrings.FormatParam>.NativeClassPtr, 100667175);
			}

			// Token: 0x06005185 RID: 20869 RVA: 0x00171130 File Offset: 0x0016F330
			[CallerCount(0)]
			public unsafe FormatParam(int value)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParameterizedStrings.FormatParam>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterizedStrings.FormatParam.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005186 RID: 20870 RVA: 0x0017117C File Offset: 0x0016F37C
			[CallerCount(0)]
			public unsafe FormatParam(int intValue, string stringValue)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParameterizedStrings.FormatParam>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref intValue;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(stringValue);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterizedStrings.FormatParam.NativeMethodInfoPtr__ctor_Private_Void_Int32_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005187 RID: 20871 RVA: 0x001711DC File Offset: 0x0016F3DC
			[CallerCount(0)]
			public new unsafe static implicit operator ParameterizedStrings.FormatParam(int value)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterizedStrings.FormatParam.NativeMethodInfoPtr_op_Implicit_Public_Static_FormatParam_Int32_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new ParameterizedStrings.FormatParam(intPtr);
				}
			}

			// Token: 0x170014DE RID: 5342
			// (get) Token: 0x06005188 RID: 20872 RVA: 0x00171214 File Offset: 0x0016F414
			public unsafe int Int32
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterizedStrings.FormatParam.NativeMethodInfoPtr_get_Int32_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170014DF RID: 5343
			// (get) Token: 0x06005189 RID: 20873 RVA: 0x00171258 File Offset: 0x0016F458
			public unsafe string String
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178158, XrefRangeEnd = 178160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterizedStrings.FormatParam.NativeMethodInfoPtr_get_String_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x170014E0 RID: 5344
			// (get) Token: 0x0600518A RID: 20874 RVA: 0x00171294 File Offset: 0x0016F494
			public unsafe Object Object
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178160, XrefRangeEnd = 178163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterizedStrings.FormatParam.NativeMethodInfoPtr_get_Object_Public_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600518B RID: 20875 RVA: 0x0001EA12 File Offset: 0x0001CC12
			public FormatParam(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600518C RID: 20876 RVA: 0x0001EA1B File Offset: 0x0001CC1B
			public FormatParam()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParameterizedStrings.FormatParam>.NativeClassPtr))
			{
			}

			// Token: 0x170014DC RID: 5340
			// (get) Token: 0x0600518D RID: 20877 RVA: 0x001712D8 File Offset: 0x0016F4D8
			// (set) Token: 0x0600518E RID: 20878 RVA: 0x0001EA2D File Offset: 0x0001CC2D
			public unsafe int _int32
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParameterizedStrings.FormatParam.NativeFieldInfoPtr__int32);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParameterizedStrings.FormatParam.NativeFieldInfoPtr__int32)) = value;
				}
			}

			// Token: 0x170014DD RID: 5341
			// (get) Token: 0x0600518F RID: 20879 RVA: 0x00171300 File Offset: 0x0016F500
			// (set) Token: 0x06005190 RID: 20880 RVA: 0x0001EA48 File Offset: 0x0001CC48
			public unsafe string _string
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParameterizedStrings.FormatParam.NativeFieldInfoPtr__string);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParameterizedStrings.FormatParam.NativeFieldInfoPtr__string), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04004250 RID: 16976
			private static readonly IntPtr NativeFieldInfoPtr__int32;

			// Token: 0x04004251 RID: 16977
			private static readonly IntPtr NativeFieldInfoPtr__string;

			// Token: 0x04004252 RID: 16978
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04004253 RID: 16979
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Int32_String_0;

			// Token: 0x04004254 RID: 16980
			private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_FormatParam_Int32_0;

			// Token: 0x04004255 RID: 16981
			private static readonly IntPtr NativeMethodInfoPtr_get_Int32_Public_get_Int32_0;

			// Token: 0x04004256 RID: 16982
			private static readonly IntPtr NativeMethodInfoPtr_get_String_Public_get_String_0;

			// Token: 0x04004257 RID: 16983
			private static readonly IntPtr NativeMethodInfoPtr_get_Object_Public_get_Object_0;
		}

		// Token: 0x020005B0 RID: 1456
		public sealed class LowLevelStack : Object
		{
			// Token: 0x06005191 RID: 20881 RVA: 0x00171328 File Offset: 0x0016F528
			// Note: this type is marked as 'beforefieldinit'.
			static LowLevelStack()
			{
				Il2CppClassPointerStore<ParameterizedStrings.LowLevelStack>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParameterizedStrings>.NativeClassPtr, "LowLevelStack");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParameterizedStrings.LowLevelStack>.NativeClassPtr);
				ParameterizedStrings.LowLevelStack.NativeFieldInfoPtr__arr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParameterizedStrings.LowLevelStack>.NativeClassPtr, "_arr");
				ParameterizedStrings.LowLevelStack.NativeFieldInfoPtr__count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParameterizedStrings.LowLevelStack>.NativeClassPtr, "_count");
				ParameterizedStrings.LowLevelStack.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterizedStrings.LowLevelStack>.NativeClassPtr, 100667176);
				ParameterizedStrings.LowLevelStack.NativeMethodInfoPtr_Pop_Public_FormatParam_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterizedStrings.LowLevelStack>.NativeClassPtr, 100667177);
				ParameterizedStrings.LowLevelStack.NativeMethodInfoPtr_Push_Public_Void_FormatParam_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterizedStrings.LowLevelStack>.NativeClassPtr, 100667178);
				ParameterizedStrings.LowLevelStack.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterizedStrings.LowLevelStack>.NativeClassPtr, 100667179);
			}

			// Token: 0x06005192 RID: 20882 RVA: 0x001713CC File Offset: 0x0016F5CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178163, XrefRangeEnd = 178166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LowLevelStack()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParameterizedStrings.LowLevelStack>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterizedStrings.LowLevelStack.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005193 RID: 20883 RVA: 0x00171408 File Offset: 0x0016F608
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 178166, RefRangeEnd = 178178, XrefRangeStart = 178166, XrefRangeEnd = 178166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ParameterizedStrings.FormatParam Pop()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterizedStrings.LowLevelStack.NativeMethodInfoPtr_Pop_Public_FormatParam_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ParameterizedStrings.FormatParam(intPtr);
			}

			// Token: 0x06005194 RID: 20884 RVA: 0x00171440 File Offset: 0x0016F640
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 178182, RefRangeEnd = 178190, XrefRangeStart = 178178, XrefRangeEnd = 178182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Push(ParameterizedStrings.FormatParam item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(item));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterizedStrings.LowLevelStack.NativeMethodInfoPtr_Push_Public_Void_FormatParam_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005195 RID: 20885 RVA: 0x00171488 File Offset: 0x0016F688
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178190, XrefRangeEnd = 178191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Clear()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterizedStrings.LowLevelStack.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005196 RID: 20886 RVA: 0x0001EA67 File Offset: 0x0001CC67
			public LowLevelStack(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170014E1 RID: 5345
			// (get) Token: 0x06005197 RID: 20887 RVA: 0x001714BC File Offset: 0x0016F6BC
			// (set) Token: 0x06005198 RID: 20888 RVA: 0x0001EA70 File Offset: 0x0001CC70
			public unsafe Il2CppReferenceArray<ParameterizedStrings.FormatParam> _arr
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParameterizedStrings.LowLevelStack.NativeFieldInfoPtr__arr);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ParameterizedStrings.FormatParam>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParameterizedStrings.LowLevelStack.NativeFieldInfoPtr__arr), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170014E2 RID: 5346
			// (get) Token: 0x06005199 RID: 20889 RVA: 0x001714EC File Offset: 0x0016F6EC
			// (set) Token: 0x0600519A RID: 20890 RVA: 0x0001EA8F File Offset: 0x0001CC8F
			public unsafe int _count
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParameterizedStrings.LowLevelStack.NativeFieldInfoPtr__count);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParameterizedStrings.LowLevelStack.NativeFieldInfoPtr__count)) = value;
				}
			}

			// Token: 0x04004258 RID: 16984
			private static readonly IntPtr NativeFieldInfoPtr__arr;

			// Token: 0x04004259 RID: 16985
			private static readonly IntPtr NativeFieldInfoPtr__count;

			// Token: 0x0400425A RID: 16986
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400425B RID: 16987
			private static readonly IntPtr NativeMethodInfoPtr_Pop_Public_FormatParam_0;

			// Token: 0x0400425C RID: 16988
			private static readonly IntPtr NativeMethodInfoPtr_Push_Public_Void_FormatParam_0;

			// Token: 0x0400425D RID: 16989
			private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;
		}
	}
}
