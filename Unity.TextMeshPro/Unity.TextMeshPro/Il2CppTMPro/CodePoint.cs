using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppTMPro
{
	// Token: 0x02000038 RID: 56
	public static class CodePoint : Object
	{
		// Token: 0x0600059C RID: 1436 RVA: 0x0001DA68 File Offset: 0x0001BC68
		// Note: this type is marked as 'beforefieldinit'.
		static CodePoint()
		{
			Il2CppClassPointerStore<CodePoint>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "CodePoint");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CodePoint>.NativeClassPtr);
			CodePoint.NativeFieldInfoPtr_SPACE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodePoint>.NativeClassPtr, "SPACE");
			CodePoint.NativeFieldInfoPtr_DOUBLE_QUOTE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodePoint>.NativeClassPtr, "DOUBLE_QUOTE");
			CodePoint.NativeFieldInfoPtr_NUMBER_SIGN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodePoint>.NativeClassPtr, "NUMBER_SIGN");
			CodePoint.NativeFieldInfoPtr_PERCENTAGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodePoint>.NativeClassPtr, "PERCENTAGE");
			CodePoint.NativeFieldInfoPtr_PLUS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodePoint>.NativeClassPtr, "PLUS");
			CodePoint.NativeFieldInfoPtr_MINUS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodePoint>.NativeClassPtr, "MINUS");
			CodePoint.NativeFieldInfoPtr_PERIOD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodePoint>.NativeClassPtr, "PERIOD");
			CodePoint.NativeFieldInfoPtr_HYPHEN_MINUS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodePoint>.NativeClassPtr, "HYPHEN_MINUS");
			CodePoint.NativeFieldInfoPtr_SOFT_HYPHEN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodePoint>.NativeClassPtr, "SOFT_HYPHEN");
			CodePoint.NativeFieldInfoPtr_HYPHEN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodePoint>.NativeClassPtr, "HYPHEN");
			CodePoint.NativeFieldInfoPtr_NON_BREAKING_HYPHEN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodePoint>.NativeClassPtr, "NON_BREAKING_HYPHEN");
			CodePoint.NativeFieldInfoPtr_ZERO_WIDTH_SPACE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodePoint>.NativeClassPtr, "ZERO_WIDTH_SPACE");
			CodePoint.NativeFieldInfoPtr_RIGHT_SINGLE_QUOTATION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodePoint>.NativeClassPtr, "RIGHT_SINGLE_QUOTATION");
			CodePoint.NativeFieldInfoPtr_APOSTROPHE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodePoint>.NativeClassPtr, "APOSTROPHE");
			CodePoint.NativeFieldInfoPtr_WORD_JOINER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodePoint>.NativeClassPtr, "WORD_JOINER");
			CodePoint.NativeFieldInfoPtr_HIGH_SURROGATE_START = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodePoint>.NativeClassPtr, "HIGH_SURROGATE_START");
			CodePoint.NativeFieldInfoPtr_HIGH_SURROGATE_END = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodePoint>.NativeClassPtr, "HIGH_SURROGATE_END");
			CodePoint.NativeFieldInfoPtr_LOW_SURROGATE_START = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodePoint>.NativeClassPtr, "LOW_SURROGATE_START");
			CodePoint.NativeFieldInfoPtr_LOW_SURROGATE_END = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodePoint>.NativeClassPtr, "LOW_SURROGATE_END");
			CodePoint.NativeFieldInfoPtr_UNICODE_PLANE01_START = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodePoint>.NativeClassPtr, "UNICODE_PLANE01_START");
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x000048E4 File Offset: 0x00002AE4
		public CodePoint(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x0600059E RID: 1438 RVA: 0x0001DC28 File Offset: 0x0001BE28
		// (set) Token: 0x0600059F RID: 1439 RVA: 0x000048ED File Offset: 0x00002AED
		public unsafe static uint SPACE
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(CodePoint.NativeFieldInfoPtr_SPACE, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CodePoint.NativeFieldInfoPtr_SPACE, (void*)(&value));
			}
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x060005A0 RID: 1440 RVA: 0x0001DC44 File Offset: 0x0001BE44
		// (set) Token: 0x060005A1 RID: 1441 RVA: 0x000048FB File Offset: 0x00002AFB
		public unsafe static uint DOUBLE_QUOTE
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(CodePoint.NativeFieldInfoPtr_DOUBLE_QUOTE, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CodePoint.NativeFieldInfoPtr_DOUBLE_QUOTE, (void*)(&value));
			}
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x060005A2 RID: 1442 RVA: 0x0001DC60 File Offset: 0x0001BE60
		// (set) Token: 0x060005A3 RID: 1443 RVA: 0x00004909 File Offset: 0x00002B09
		public unsafe static uint NUMBER_SIGN
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(CodePoint.NativeFieldInfoPtr_NUMBER_SIGN, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CodePoint.NativeFieldInfoPtr_NUMBER_SIGN, (void*)(&value));
			}
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x060005A4 RID: 1444 RVA: 0x0001DC7C File Offset: 0x0001BE7C
		// (set) Token: 0x060005A5 RID: 1445 RVA: 0x00004917 File Offset: 0x00002B17
		public unsafe static uint PERCENTAGE
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(CodePoint.NativeFieldInfoPtr_PERCENTAGE, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CodePoint.NativeFieldInfoPtr_PERCENTAGE, (void*)(&value));
			}
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x060005A6 RID: 1446 RVA: 0x0001DC98 File Offset: 0x0001BE98
		// (set) Token: 0x060005A7 RID: 1447 RVA: 0x00004925 File Offset: 0x00002B25
		public unsafe static uint PLUS
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(CodePoint.NativeFieldInfoPtr_PLUS, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CodePoint.NativeFieldInfoPtr_PLUS, (void*)(&value));
			}
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x060005A8 RID: 1448 RVA: 0x0001DCB4 File Offset: 0x0001BEB4
		// (set) Token: 0x060005A9 RID: 1449 RVA: 0x00004933 File Offset: 0x00002B33
		public unsafe static uint MINUS
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(CodePoint.NativeFieldInfoPtr_MINUS, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CodePoint.NativeFieldInfoPtr_MINUS, (void*)(&value));
			}
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x060005AA RID: 1450 RVA: 0x0001DCD0 File Offset: 0x0001BED0
		// (set) Token: 0x060005AB RID: 1451 RVA: 0x00004941 File Offset: 0x00002B41
		public unsafe static uint PERIOD
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(CodePoint.NativeFieldInfoPtr_PERIOD, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CodePoint.NativeFieldInfoPtr_PERIOD, (void*)(&value));
			}
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x060005AC RID: 1452 RVA: 0x0001DCEC File Offset: 0x0001BEEC
		// (set) Token: 0x060005AD RID: 1453 RVA: 0x0000494F File Offset: 0x00002B4F
		public unsafe static uint HYPHEN_MINUS
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(CodePoint.NativeFieldInfoPtr_HYPHEN_MINUS, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CodePoint.NativeFieldInfoPtr_HYPHEN_MINUS, (void*)(&value));
			}
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x060005AE RID: 1454 RVA: 0x0001DD08 File Offset: 0x0001BF08
		// (set) Token: 0x060005AF RID: 1455 RVA: 0x0000495D File Offset: 0x00002B5D
		public unsafe static uint SOFT_HYPHEN
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(CodePoint.NativeFieldInfoPtr_SOFT_HYPHEN, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CodePoint.NativeFieldInfoPtr_SOFT_HYPHEN, (void*)(&value));
			}
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x060005B0 RID: 1456 RVA: 0x0001DD24 File Offset: 0x0001BF24
		// (set) Token: 0x060005B1 RID: 1457 RVA: 0x0000496B File Offset: 0x00002B6B
		public unsafe static uint HYPHEN
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(CodePoint.NativeFieldInfoPtr_HYPHEN, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CodePoint.NativeFieldInfoPtr_HYPHEN, (void*)(&value));
			}
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x060005B2 RID: 1458 RVA: 0x0001DD40 File Offset: 0x0001BF40
		// (set) Token: 0x060005B3 RID: 1459 RVA: 0x00004979 File Offset: 0x00002B79
		public unsafe static uint NON_BREAKING_HYPHEN
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(CodePoint.NativeFieldInfoPtr_NON_BREAKING_HYPHEN, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CodePoint.NativeFieldInfoPtr_NON_BREAKING_HYPHEN, (void*)(&value));
			}
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x060005B4 RID: 1460 RVA: 0x0001DD5C File Offset: 0x0001BF5C
		// (set) Token: 0x060005B5 RID: 1461 RVA: 0x00004987 File Offset: 0x00002B87
		public unsafe static uint ZERO_WIDTH_SPACE
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(CodePoint.NativeFieldInfoPtr_ZERO_WIDTH_SPACE, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CodePoint.NativeFieldInfoPtr_ZERO_WIDTH_SPACE, (void*)(&value));
			}
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x060005B6 RID: 1462 RVA: 0x0001DD78 File Offset: 0x0001BF78
		// (set) Token: 0x060005B7 RID: 1463 RVA: 0x00004995 File Offset: 0x00002B95
		public unsafe static uint RIGHT_SINGLE_QUOTATION
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(CodePoint.NativeFieldInfoPtr_RIGHT_SINGLE_QUOTATION, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CodePoint.NativeFieldInfoPtr_RIGHT_SINGLE_QUOTATION, (void*)(&value));
			}
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x060005B8 RID: 1464 RVA: 0x0001DD94 File Offset: 0x0001BF94
		// (set) Token: 0x060005B9 RID: 1465 RVA: 0x000049A3 File Offset: 0x00002BA3
		public unsafe static uint APOSTROPHE
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(CodePoint.NativeFieldInfoPtr_APOSTROPHE, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CodePoint.NativeFieldInfoPtr_APOSTROPHE, (void*)(&value));
			}
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x060005BA RID: 1466 RVA: 0x0001DDB0 File Offset: 0x0001BFB0
		// (set) Token: 0x060005BB RID: 1467 RVA: 0x000049B1 File Offset: 0x00002BB1
		public unsafe static uint WORD_JOINER
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(CodePoint.NativeFieldInfoPtr_WORD_JOINER, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CodePoint.NativeFieldInfoPtr_WORD_JOINER, (void*)(&value));
			}
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x060005BC RID: 1468 RVA: 0x0001DDCC File Offset: 0x0001BFCC
		// (set) Token: 0x060005BD RID: 1469 RVA: 0x000049BF File Offset: 0x00002BBF
		public unsafe static uint HIGH_SURROGATE_START
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(CodePoint.NativeFieldInfoPtr_HIGH_SURROGATE_START, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CodePoint.NativeFieldInfoPtr_HIGH_SURROGATE_START, (void*)(&value));
			}
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x060005BE RID: 1470 RVA: 0x0001DDE8 File Offset: 0x0001BFE8
		// (set) Token: 0x060005BF RID: 1471 RVA: 0x000049CD File Offset: 0x00002BCD
		public unsafe static uint HIGH_SURROGATE_END
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(CodePoint.NativeFieldInfoPtr_HIGH_SURROGATE_END, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CodePoint.NativeFieldInfoPtr_HIGH_SURROGATE_END, (void*)(&value));
			}
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x060005C0 RID: 1472 RVA: 0x0001DE04 File Offset: 0x0001C004
		// (set) Token: 0x060005C1 RID: 1473 RVA: 0x000049DB File Offset: 0x00002BDB
		public unsafe static uint LOW_SURROGATE_START
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(CodePoint.NativeFieldInfoPtr_LOW_SURROGATE_START, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CodePoint.NativeFieldInfoPtr_LOW_SURROGATE_START, (void*)(&value));
			}
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x060005C2 RID: 1474 RVA: 0x0001DE20 File Offset: 0x0001C020
		// (set) Token: 0x060005C3 RID: 1475 RVA: 0x000049E9 File Offset: 0x00002BE9
		public unsafe static uint LOW_SURROGATE_END
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(CodePoint.NativeFieldInfoPtr_LOW_SURROGATE_END, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CodePoint.NativeFieldInfoPtr_LOW_SURROGATE_END, (void*)(&value));
			}
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x060005C4 RID: 1476 RVA: 0x0001DE3C File Offset: 0x0001C03C
		// (set) Token: 0x060005C5 RID: 1477 RVA: 0x000049F7 File Offset: 0x00002BF7
		public unsafe static uint UNICODE_PLANE01_START
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(CodePoint.NativeFieldInfoPtr_UNICODE_PLANE01_START, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CodePoint.NativeFieldInfoPtr_UNICODE_PLANE01_START, (void*)(&value));
			}
		}

		// Token: 0x040004C5 RID: 1221
		private static readonly IntPtr NativeFieldInfoPtr_SPACE;

		// Token: 0x040004C6 RID: 1222
		private static readonly IntPtr NativeFieldInfoPtr_DOUBLE_QUOTE;

		// Token: 0x040004C7 RID: 1223
		private static readonly IntPtr NativeFieldInfoPtr_NUMBER_SIGN;

		// Token: 0x040004C8 RID: 1224
		private static readonly IntPtr NativeFieldInfoPtr_PERCENTAGE;

		// Token: 0x040004C9 RID: 1225
		private static readonly IntPtr NativeFieldInfoPtr_PLUS;

		// Token: 0x040004CA RID: 1226
		private static readonly IntPtr NativeFieldInfoPtr_MINUS;

		// Token: 0x040004CB RID: 1227
		private static readonly IntPtr NativeFieldInfoPtr_PERIOD;

		// Token: 0x040004CC RID: 1228
		private static readonly IntPtr NativeFieldInfoPtr_HYPHEN_MINUS;

		// Token: 0x040004CD RID: 1229
		private static readonly IntPtr NativeFieldInfoPtr_SOFT_HYPHEN;

		// Token: 0x040004CE RID: 1230
		private static readonly IntPtr NativeFieldInfoPtr_HYPHEN;

		// Token: 0x040004CF RID: 1231
		private static readonly IntPtr NativeFieldInfoPtr_NON_BREAKING_HYPHEN;

		// Token: 0x040004D0 RID: 1232
		private static readonly IntPtr NativeFieldInfoPtr_ZERO_WIDTH_SPACE;

		// Token: 0x040004D1 RID: 1233
		private static readonly IntPtr NativeFieldInfoPtr_RIGHT_SINGLE_QUOTATION;

		// Token: 0x040004D2 RID: 1234
		private static readonly IntPtr NativeFieldInfoPtr_APOSTROPHE;

		// Token: 0x040004D3 RID: 1235
		private static readonly IntPtr NativeFieldInfoPtr_WORD_JOINER;

		// Token: 0x040004D4 RID: 1236
		private static readonly IntPtr NativeFieldInfoPtr_HIGH_SURROGATE_START;

		// Token: 0x040004D5 RID: 1237
		private static readonly IntPtr NativeFieldInfoPtr_HIGH_SURROGATE_END;

		// Token: 0x040004D6 RID: 1238
		private static readonly IntPtr NativeFieldInfoPtr_LOW_SURROGATE_START;

		// Token: 0x040004D7 RID: 1239
		private static readonly IntPtr NativeFieldInfoPtr_LOW_SURROGATE_END;

		// Token: 0x040004D8 RID: 1240
		private static readonly IntPtr NativeFieldInfoPtr_UNICODE_PLANE01_START;
	}
}
