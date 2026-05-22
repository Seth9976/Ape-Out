using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Globalization;

namespace Il2CppSystem.Text.RegularExpressions
{
	// Token: 0x0200005A RID: 90
	public sealed class RegexInterpreter : RegexRunner
	{
		// Token: 0x060005A9 RID: 1449 RVA: 0x00026680 File Offset: 0x00024880
		// Note: this type is marked as 'beforefieldinit'.
		static RegexInterpreter()
		{
			Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Text.RegularExpressions", "RegexInterpreter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr);
			RegexInterpreter.NativeFieldInfoPtr_runoperator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, "runoperator");
			RegexInterpreter.NativeFieldInfoPtr_runcodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, "runcodes");
			RegexInterpreter.NativeFieldInfoPtr_runcodepos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, "runcodepos");
			RegexInterpreter.NativeFieldInfoPtr_runstrings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, "runstrings");
			RegexInterpreter.NativeFieldInfoPtr_runcode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, "runcode");
			RegexInterpreter.NativeFieldInfoPtr_runfcPrefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, "runfcPrefix");
			RegexInterpreter.NativeFieldInfoPtr_runbmPrefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, "runbmPrefix");
			RegexInterpreter.NativeFieldInfoPtr_runanchors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, "runanchors");
			RegexInterpreter.NativeFieldInfoPtr_runrtl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, "runrtl");
			RegexInterpreter.NativeFieldInfoPtr_runci = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, "runci");
			RegexInterpreter.NativeFieldInfoPtr_runculture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, "runculture");
			RegexInterpreter.NativeMethodInfoPtr__ctor_Internal_Void_RegexCode_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664172);
			RegexInterpreter.NativeMethodInfoPtr_InitTrackCount_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664173);
			RegexInterpreter.NativeMethodInfoPtr_Advance_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664174);
			RegexInterpreter.NativeMethodInfoPtr_Advance_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664175);
			RegexInterpreter.NativeMethodInfoPtr_Goto_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664176);
			RegexInterpreter.NativeMethodInfoPtr_Textto_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664177);
			RegexInterpreter.NativeMethodInfoPtr_Trackto_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664178);
			RegexInterpreter.NativeMethodInfoPtr_Textstart_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664179);
			RegexInterpreter.NativeMethodInfoPtr_Textpos_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664180);
			RegexInterpreter.NativeMethodInfoPtr_Trackpos_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664181);
			RegexInterpreter.NativeMethodInfoPtr_TrackPush_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664182);
			RegexInterpreter.NativeMethodInfoPtr_TrackPush_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664183);
			RegexInterpreter.NativeMethodInfoPtr_TrackPush_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664184);
			RegexInterpreter.NativeMethodInfoPtr_TrackPush_Private_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664185);
			RegexInterpreter.NativeMethodInfoPtr_TrackPush2_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664186);
			RegexInterpreter.NativeMethodInfoPtr_TrackPush2_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664187);
			RegexInterpreter.NativeMethodInfoPtr_Backtrack_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664188);
			RegexInterpreter.NativeMethodInfoPtr_SetOperator_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664189);
			RegexInterpreter.NativeMethodInfoPtr_TrackPop_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664190);
			RegexInterpreter.NativeMethodInfoPtr_TrackPop_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664191);
			RegexInterpreter.NativeMethodInfoPtr_TrackPeek_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664192);
			RegexInterpreter.NativeMethodInfoPtr_TrackPeek_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664193);
			RegexInterpreter.NativeMethodInfoPtr_StackPush_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664194);
			RegexInterpreter.NativeMethodInfoPtr_StackPush_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664195);
			RegexInterpreter.NativeMethodInfoPtr_StackPop_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664196);
			RegexInterpreter.NativeMethodInfoPtr_StackPop_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664197);
			RegexInterpreter.NativeMethodInfoPtr_StackPeek_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664198);
			RegexInterpreter.NativeMethodInfoPtr_StackPeek_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664199);
			RegexInterpreter.NativeMethodInfoPtr_Operator_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664200);
			RegexInterpreter.NativeMethodInfoPtr_Operand_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664201);
			RegexInterpreter.NativeMethodInfoPtr_Leftchars_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664202);
			RegexInterpreter.NativeMethodInfoPtr_Rightchars_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664203);
			RegexInterpreter.NativeMethodInfoPtr_Bump_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664204);
			RegexInterpreter.NativeMethodInfoPtr_Forwardchars_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664205);
			RegexInterpreter.NativeMethodInfoPtr_Forwardcharnext_Private_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664206);
			RegexInterpreter.NativeMethodInfoPtr_Stringmatch_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664207);
			RegexInterpreter.NativeMethodInfoPtr_Refmatch_Private_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664208);
			RegexInterpreter.NativeMethodInfoPtr_Backwardnext_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664209);
			RegexInterpreter.NativeMethodInfoPtr_CharAt_Private_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664210);
			RegexInterpreter.NativeMethodInfoPtr_FindFirstChar_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664211);
			RegexInterpreter.NativeMethodInfoPtr_Go_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664212);
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x00026AC0 File Offset: 0x00024CC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 370649, RefRangeEnd = 370650, XrefRangeStart = 370649, XrefRangeEnd = 370649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexInterpreter(RegexCode code, CultureInfo culture)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(code);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(culture);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr__ctor_Internal_Void_RegexCode_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x00026B20 File Offset: 0x00024D20
		[CallerCount(0)]
		public unsafe override void InitTrackCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_InitTrackCount_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x00026B54 File Offset: 0x00024D54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370650, XrefRangeEnd = 370651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Advance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_Advance_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x00026B88 File Offset: 0x00024D88
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 370651, RefRangeEnd = 370672, XrefRangeStart = 370651, XrefRangeEnd = 370651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Advance(int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_Advance_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x00026BC8 File Offset: 0x00024DC8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 370673, RefRangeEnd = 370681, XrefRangeStart = 370672, XrefRangeEnd = 370673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Goto(int newpos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newpos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_Goto_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x00026C08 File Offset: 0x00024E08
		[CallerCount(0)]
		public unsafe void Textto(int newpos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newpos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_Textto_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x00026C48 File Offset: 0x00024E48
		[CallerCount(0)]
		public unsafe void Trackto(int newpos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newpos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_Trackto_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x00026C88 File Offset: 0x00024E88
		[CallerCount(0)]
		public unsafe int Textstart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_Textstart_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x00026CC4 File Offset: 0x00024EC4
		[CallerCount(0)]
		public unsafe int Textpos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_Textpos_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x00026D00 File Offset: 0x00024F00
		[CallerCount(0)]
		public unsafe int Trackpos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_Trackpos_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x00026D3C File Offset: 0x00024F3C
		[CallerCount(0)]
		public unsafe void TrackPush()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_TrackPush_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x00026D70 File Offset: 0x00024F70
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 370681, RefRangeEnd = 370686, XrefRangeStart = 370681, XrefRangeEnd = 370681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TrackPush(int I1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref I1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_TrackPush_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x00026DB0 File Offset: 0x00024FB0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 370686, RefRangeEnd = 370689, XrefRangeStart = 370686, XrefRangeEnd = 370686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TrackPush(int I1, int I2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref I1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref I2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_TrackPush_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x00026DFC File Offset: 0x00024FFC
		[CallerCount(0)]
		public unsafe void TrackPush(int I1, int I2, int I3)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref I1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref I2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref I3;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_TrackPush_Private_Void_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005B8 RID: 1464 RVA: 0x00026E58 File Offset: 0x00025058
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 370689, RefRangeEnd = 370695, XrefRangeStart = 370689, XrefRangeEnd = 370689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TrackPush2(int I1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref I1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_TrackPush2_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x00026E98 File Offset: 0x00025098
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 370695, RefRangeEnd = 370697, XrefRangeStart = 370695, XrefRangeEnd = 370695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TrackPush2(int I1, int I2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref I1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref I2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_TrackPush2_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x00026EE4 File Offset: 0x000250E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370697, XrefRangeEnd = 370699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Backtrack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_Backtrack_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x00026F18 File Offset: 0x00025118
		[CallerCount(0)]
		public unsafe void SetOperator(int op)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref op;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_SetOperator_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x00026F58 File Offset: 0x00025158
		[CallerCount(0)]
		public unsafe void TrackPop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_TrackPop_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x00026F8C File Offset: 0x0002518C
		[CallerCount(0)]
		public unsafe void TrackPop(int framesize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref framesize;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_TrackPop_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x00026FCC File Offset: 0x000251CC
		[CallerCount(0)]
		public unsafe int TrackPeek()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_TrackPeek_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x00027008 File Offset: 0x00025208
		[CallerCount(0)]
		public unsafe int TrackPeek(int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_TrackPeek_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x00027054 File Offset: 0x00025254
		[CallerCount(0)]
		public unsafe void StackPush(int I1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref I1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_StackPush_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x00027094 File Offset: 0x00025294
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 370699, RefRangeEnd = 370706, XrefRangeStart = 370699, XrefRangeEnd = 370699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StackPush(int I1, int I2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref I1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref I2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_StackPush_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x000270E0 File Offset: 0x000252E0
		[CallerCount(0)]
		public unsafe void StackPop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_StackPop_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x00027114 File Offset: 0x00025314
		[CallerCount(0)]
		public unsafe void StackPop(int framesize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref framesize;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_StackPop_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x00027154 File Offset: 0x00025354
		[CallerCount(0)]
		public unsafe int StackPeek()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_StackPeek_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x00027190 File Offset: 0x00025390
		[CallerCount(0)]
		public unsafe int StackPeek(int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_StackPeek_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x000271DC File Offset: 0x000253DC
		[CallerCount(0)]
		public unsafe int Operator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_Operator_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x00027218 File Offset: 0x00025418
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 370706, RefRangeEnd = 370721, XrefRangeStart = 370706, XrefRangeEnd = 370706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Operand(int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_Operand_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x00027264 File Offset: 0x00025464
		[CallerCount(0)]
		public unsafe int Leftchars()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_Leftchars_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x000272A0 File Offset: 0x000254A0
		[CallerCount(0)]
		public unsafe int Rightchars()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_Rightchars_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005CA RID: 1482 RVA: 0x000272DC File Offset: 0x000254DC
		[CallerCount(0)]
		public unsafe int Bump()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_Bump_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005CB RID: 1483 RVA: 0x00027318 File Offset: 0x00025518
		[CallerCount(0)]
		public unsafe int Forwardchars()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_Forwardchars_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005CC RID: 1484 RVA: 0x00027354 File Offset: 0x00025554
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 370725, RefRangeEnd = 370738, XrefRangeStart = 370721, XrefRangeEnd = 370725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe char Forwardcharnext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_Forwardcharnext_Private_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x00027390 File Offset: 0x00025590
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 370742, RefRangeEnd = 370743, XrefRangeStart = 370738, XrefRangeEnd = 370742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Stringmatch(string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_Stringmatch_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x000273E0 File Offset: 0x000255E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 370748, RefRangeEnd = 370749, XrefRangeStart = 370743, XrefRangeEnd = 370748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Refmatch(int index, int len)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_Refmatch_Private_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005CF RID: 1487 RVA: 0x00027438 File Offset: 0x00025638
		[CallerCount(0)]
		public unsafe void Backwardnext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_Backwardnext_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005D0 RID: 1488 RVA: 0x0002746C File Offset: 0x0002566C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 370749, RefRangeEnd = 370752, XrefRangeStart = 370749, XrefRangeEnd = 370749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe char CharAt(int j)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref j;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_CharAt_Private_Char_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005D1 RID: 1489 RVA: 0x000274B8 File Offset: 0x000256B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370752, XrefRangeEnd = 370761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool FindFirstChar()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_FindFirstChar_Protected_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005D2 RID: 1490 RVA: 0x000274F4 File Offset: 0x000256F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370761, XrefRangeEnd = 370950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Go()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_Go_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005D3 RID: 1491 RVA: 0x00004227 File Offset: 0x00002427
		public RegexInterpreter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x060005D4 RID: 1492 RVA: 0x00027528 File Offset: 0x00025728
		// (set) Token: 0x060005D5 RID: 1493 RVA: 0x00004230 File Offset: 0x00002430
		public unsafe int runoperator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexInterpreter.NativeFieldInfoPtr_runoperator);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexInterpreter.NativeFieldInfoPtr_runoperator)) = value;
			}
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x060005D6 RID: 1494 RVA: 0x00027550 File Offset: 0x00025750
		// (set) Token: 0x060005D7 RID: 1495 RVA: 0x0000424B File Offset: 0x0000244B
		public unsafe Il2CppStructArray<int> runcodes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexInterpreter.NativeFieldInfoPtr_runcodes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexInterpreter.NativeFieldInfoPtr_runcodes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x060005D8 RID: 1496 RVA: 0x00027580 File Offset: 0x00025780
		// (set) Token: 0x060005D9 RID: 1497 RVA: 0x0000426A File Offset: 0x0000246A
		public unsafe int runcodepos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexInterpreter.NativeFieldInfoPtr_runcodepos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexInterpreter.NativeFieldInfoPtr_runcodepos)) = value;
			}
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x060005DA RID: 1498 RVA: 0x000275A8 File Offset: 0x000257A8
		// (set) Token: 0x060005DB RID: 1499 RVA: 0x00004285 File Offset: 0x00002485
		public unsafe Il2CppStringArray runstrings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexInterpreter.NativeFieldInfoPtr_runstrings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexInterpreter.NativeFieldInfoPtr_runstrings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x060005DC RID: 1500 RVA: 0x000275D8 File Offset: 0x000257D8
		// (set) Token: 0x060005DD RID: 1501 RVA: 0x000042A4 File Offset: 0x000024A4
		public unsafe RegexCode runcode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexInterpreter.NativeFieldInfoPtr_runcode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegexCode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexInterpreter.NativeFieldInfoPtr_runcode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x060005DE RID: 1502 RVA: 0x00027608 File Offset: 0x00025808
		// (set) Token: 0x060005DF RID: 1503 RVA: 0x000042C3 File Offset: 0x000024C3
		public unsafe RegexPrefix runfcPrefix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexInterpreter.NativeFieldInfoPtr_runfcPrefix);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegexPrefix>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexInterpreter.NativeFieldInfoPtr_runfcPrefix), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x060005E0 RID: 1504 RVA: 0x00027638 File Offset: 0x00025838
		// (set) Token: 0x060005E1 RID: 1505 RVA: 0x000042E2 File Offset: 0x000024E2
		public unsafe RegexBoyerMoore runbmPrefix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexInterpreter.NativeFieldInfoPtr_runbmPrefix);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegexBoyerMoore>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexInterpreter.NativeFieldInfoPtr_runbmPrefix), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x060005E2 RID: 1506 RVA: 0x00027668 File Offset: 0x00025868
		// (set) Token: 0x060005E3 RID: 1507 RVA: 0x00004301 File Offset: 0x00002501
		public unsafe int runanchors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexInterpreter.NativeFieldInfoPtr_runanchors);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexInterpreter.NativeFieldInfoPtr_runanchors)) = value;
			}
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x060005E4 RID: 1508 RVA: 0x00027690 File Offset: 0x00025890
		// (set) Token: 0x060005E5 RID: 1509 RVA: 0x0000431C File Offset: 0x0000251C
		public unsafe bool runrtl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexInterpreter.NativeFieldInfoPtr_runrtl);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexInterpreter.NativeFieldInfoPtr_runrtl)) = value;
			}
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x060005E6 RID: 1510 RVA: 0x000276B8 File Offset: 0x000258B8
		// (set) Token: 0x060005E7 RID: 1511 RVA: 0x00004337 File Offset: 0x00002537
		public unsafe bool runci
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexInterpreter.NativeFieldInfoPtr_runci);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexInterpreter.NativeFieldInfoPtr_runci)) = value;
			}
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x060005E8 RID: 1512 RVA: 0x000276E0 File Offset: 0x000258E0
		// (set) Token: 0x060005E9 RID: 1513 RVA: 0x00004352 File Offset: 0x00002552
		public unsafe CultureInfo runculture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexInterpreter.NativeFieldInfoPtr_runculture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexInterpreter.NativeFieldInfoPtr_runculture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000445 RID: 1093
		private static readonly IntPtr NativeFieldInfoPtr_runoperator;

		// Token: 0x04000446 RID: 1094
		private static readonly IntPtr NativeFieldInfoPtr_runcodes;

		// Token: 0x04000447 RID: 1095
		private static readonly IntPtr NativeFieldInfoPtr_runcodepos;

		// Token: 0x04000448 RID: 1096
		private static readonly IntPtr NativeFieldInfoPtr_runstrings;

		// Token: 0x04000449 RID: 1097
		private static readonly IntPtr NativeFieldInfoPtr_runcode;

		// Token: 0x0400044A RID: 1098
		private static readonly IntPtr NativeFieldInfoPtr_runfcPrefix;

		// Token: 0x0400044B RID: 1099
		private static readonly IntPtr NativeFieldInfoPtr_runbmPrefix;

		// Token: 0x0400044C RID: 1100
		private static readonly IntPtr NativeFieldInfoPtr_runanchors;

		// Token: 0x0400044D RID: 1101
		private static readonly IntPtr NativeFieldInfoPtr_runrtl;

		// Token: 0x0400044E RID: 1102
		private static readonly IntPtr NativeFieldInfoPtr_runci;

		// Token: 0x0400044F RID: 1103
		private static readonly IntPtr NativeFieldInfoPtr_runculture;

		// Token: 0x04000450 RID: 1104
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_RegexCode_CultureInfo_0;

		// Token: 0x04000451 RID: 1105
		private static readonly IntPtr NativeMethodInfoPtr_InitTrackCount_Protected_Virtual_Void_0;

		// Token: 0x04000452 RID: 1106
		private static readonly IntPtr NativeMethodInfoPtr_Advance_Private_Void_0;

		// Token: 0x04000453 RID: 1107
		private static readonly IntPtr NativeMethodInfoPtr_Advance_Private_Void_Int32_0;

		// Token: 0x04000454 RID: 1108
		private static readonly IntPtr NativeMethodInfoPtr_Goto_Private_Void_Int32_0;

		// Token: 0x04000455 RID: 1109
		private static readonly IntPtr NativeMethodInfoPtr_Textto_Private_Void_Int32_0;

		// Token: 0x04000456 RID: 1110
		private static readonly IntPtr NativeMethodInfoPtr_Trackto_Private_Void_Int32_0;

		// Token: 0x04000457 RID: 1111
		private static readonly IntPtr NativeMethodInfoPtr_Textstart_Private_Int32_0;

		// Token: 0x04000458 RID: 1112
		private static readonly IntPtr NativeMethodInfoPtr_Textpos_Private_Int32_0;

		// Token: 0x04000459 RID: 1113
		private static readonly IntPtr NativeMethodInfoPtr_Trackpos_Private_Int32_0;

		// Token: 0x0400045A RID: 1114
		private static readonly IntPtr NativeMethodInfoPtr_TrackPush_Private_Void_0;

		// Token: 0x0400045B RID: 1115
		private static readonly IntPtr NativeMethodInfoPtr_TrackPush_Private_Void_Int32_0;

		// Token: 0x0400045C RID: 1116
		private static readonly IntPtr NativeMethodInfoPtr_TrackPush_Private_Void_Int32_Int32_0;

		// Token: 0x0400045D RID: 1117
		private static readonly IntPtr NativeMethodInfoPtr_TrackPush_Private_Void_Int32_Int32_Int32_0;

		// Token: 0x0400045E RID: 1118
		private static readonly IntPtr NativeMethodInfoPtr_TrackPush2_Private_Void_Int32_0;

		// Token: 0x0400045F RID: 1119
		private static readonly IntPtr NativeMethodInfoPtr_TrackPush2_Private_Void_Int32_Int32_0;

		// Token: 0x04000460 RID: 1120
		private static readonly IntPtr NativeMethodInfoPtr_Backtrack_Private_Void_0;

		// Token: 0x04000461 RID: 1121
		private static readonly IntPtr NativeMethodInfoPtr_SetOperator_Private_Void_Int32_0;

		// Token: 0x04000462 RID: 1122
		private static readonly IntPtr NativeMethodInfoPtr_TrackPop_Private_Void_0;

		// Token: 0x04000463 RID: 1123
		private static readonly IntPtr NativeMethodInfoPtr_TrackPop_Private_Void_Int32_0;

		// Token: 0x04000464 RID: 1124
		private static readonly IntPtr NativeMethodInfoPtr_TrackPeek_Private_Int32_0;

		// Token: 0x04000465 RID: 1125
		private static readonly IntPtr NativeMethodInfoPtr_TrackPeek_Private_Int32_Int32_0;

		// Token: 0x04000466 RID: 1126
		private static readonly IntPtr NativeMethodInfoPtr_StackPush_Private_Void_Int32_0;

		// Token: 0x04000467 RID: 1127
		private static readonly IntPtr NativeMethodInfoPtr_StackPush_Private_Void_Int32_Int32_0;

		// Token: 0x04000468 RID: 1128
		private static readonly IntPtr NativeMethodInfoPtr_StackPop_Private_Void_0;

		// Token: 0x04000469 RID: 1129
		private static readonly IntPtr NativeMethodInfoPtr_StackPop_Private_Void_Int32_0;

		// Token: 0x0400046A RID: 1130
		private static readonly IntPtr NativeMethodInfoPtr_StackPeek_Private_Int32_0;

		// Token: 0x0400046B RID: 1131
		private static readonly IntPtr NativeMethodInfoPtr_StackPeek_Private_Int32_Int32_0;

		// Token: 0x0400046C RID: 1132
		private static readonly IntPtr NativeMethodInfoPtr_Operator_Private_Int32_0;

		// Token: 0x0400046D RID: 1133
		private static readonly IntPtr NativeMethodInfoPtr_Operand_Private_Int32_Int32_0;

		// Token: 0x0400046E RID: 1134
		private static readonly IntPtr NativeMethodInfoPtr_Leftchars_Private_Int32_0;

		// Token: 0x0400046F RID: 1135
		private static readonly IntPtr NativeMethodInfoPtr_Rightchars_Private_Int32_0;

		// Token: 0x04000470 RID: 1136
		private static readonly IntPtr NativeMethodInfoPtr_Bump_Private_Int32_0;

		// Token: 0x04000471 RID: 1137
		private static readonly IntPtr NativeMethodInfoPtr_Forwardchars_Private_Int32_0;

		// Token: 0x04000472 RID: 1138
		private static readonly IntPtr NativeMethodInfoPtr_Forwardcharnext_Private_Char_0;

		// Token: 0x04000473 RID: 1139
		private static readonly IntPtr NativeMethodInfoPtr_Stringmatch_Private_Boolean_String_0;

		// Token: 0x04000474 RID: 1140
		private static readonly IntPtr NativeMethodInfoPtr_Refmatch_Private_Boolean_Int32_Int32_0;

		// Token: 0x04000475 RID: 1141
		private static readonly IntPtr NativeMethodInfoPtr_Backwardnext_Private_Void_0;

		// Token: 0x04000476 RID: 1142
		private static readonly IntPtr NativeMethodInfoPtr_CharAt_Private_Char_Int32_0;

		// Token: 0x04000477 RID: 1143
		private static readonly IntPtr NativeMethodInfoPtr_FindFirstChar_Protected_Virtual_Boolean_0;

		// Token: 0x04000478 RID: 1144
		private static readonly IntPtr NativeMethodInfoPtr_Go_Protected_Virtual_Void_0;
	}
}
