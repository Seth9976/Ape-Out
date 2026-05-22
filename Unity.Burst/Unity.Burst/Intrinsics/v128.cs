using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Burst.Intrinsics
{
	// Token: 0x02000011 RID: 17
	[StructLayout(2)]
	public struct v128
	{
		// Token: 0x06000065 RID: 101 RVA: 0x00003890 File Offset: 0x00001A90
		// Note: this type is marked as 'beforefieldinit'.
		static v128()
		{
			Il2CppClassPointerStore<v128>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Burst.dll", "Unity.Burst.Intrinsics", "v128");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<v128>.NativeClassPtr);
			v128.NativeFieldInfoPtr_Byte0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "Byte0");
			v128.NativeFieldInfoPtr_Byte1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "Byte1");
			v128.NativeFieldInfoPtr_Byte2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "Byte2");
			v128.NativeFieldInfoPtr_Byte3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "Byte3");
			v128.NativeFieldInfoPtr_Byte4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "Byte4");
			v128.NativeFieldInfoPtr_Byte5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "Byte5");
			v128.NativeFieldInfoPtr_Byte6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "Byte6");
			v128.NativeFieldInfoPtr_Byte7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "Byte7");
			v128.NativeFieldInfoPtr_Byte8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "Byte8");
			v128.NativeFieldInfoPtr_Byte9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "Byte9");
			v128.NativeFieldInfoPtr_Byte10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "Byte10");
			v128.NativeFieldInfoPtr_Byte11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "Byte11");
			v128.NativeFieldInfoPtr_Byte12 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "Byte12");
			v128.NativeFieldInfoPtr_Byte13 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "Byte13");
			v128.NativeFieldInfoPtr_Byte14 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "Byte14");
			v128.NativeFieldInfoPtr_Byte15 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "Byte15");
			v128.NativeFieldInfoPtr_SByte0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "SByte0");
			v128.NativeFieldInfoPtr_SByte1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "SByte1");
			v128.NativeFieldInfoPtr_SByte2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "SByte2");
			v128.NativeFieldInfoPtr_SByte3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "SByte3");
			v128.NativeFieldInfoPtr_SByte4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "SByte4");
			v128.NativeFieldInfoPtr_SByte5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "SByte5");
			v128.NativeFieldInfoPtr_SByte6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "SByte6");
			v128.NativeFieldInfoPtr_SByte7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "SByte7");
			v128.NativeFieldInfoPtr_SByte8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "SByte8");
			v128.NativeFieldInfoPtr_SByte9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "SByte9");
			v128.NativeFieldInfoPtr_SByte10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "SByte10");
			v128.NativeFieldInfoPtr_SByte11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "SByte11");
			v128.NativeFieldInfoPtr_SByte12 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "SByte12");
			v128.NativeFieldInfoPtr_SByte13 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "SByte13");
			v128.NativeFieldInfoPtr_SByte14 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "SByte14");
			v128.NativeFieldInfoPtr_SByte15 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "SByte15");
			v128.NativeFieldInfoPtr_UShort0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "UShort0");
			v128.NativeFieldInfoPtr_UShort1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "UShort1");
			v128.NativeFieldInfoPtr_UShort2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "UShort2");
			v128.NativeFieldInfoPtr_UShort3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "UShort3");
			v128.NativeFieldInfoPtr_UShort4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "UShort4");
			v128.NativeFieldInfoPtr_UShort5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "UShort5");
			v128.NativeFieldInfoPtr_UShort6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "UShort6");
			v128.NativeFieldInfoPtr_UShort7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "UShort7");
			v128.NativeFieldInfoPtr_SShort0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "SShort0");
			v128.NativeFieldInfoPtr_SShort1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "SShort1");
			v128.NativeFieldInfoPtr_SShort2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "SShort2");
			v128.NativeFieldInfoPtr_SShort3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "SShort3");
			v128.NativeFieldInfoPtr_SShort4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "SShort4");
			v128.NativeFieldInfoPtr_SShort5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "SShort5");
			v128.NativeFieldInfoPtr_SShort6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "SShort6");
			v128.NativeFieldInfoPtr_SShort7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "SShort7");
			v128.NativeFieldInfoPtr_UInt0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "UInt0");
			v128.NativeFieldInfoPtr_UInt1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "UInt1");
			v128.NativeFieldInfoPtr_UInt2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "UInt2");
			v128.NativeFieldInfoPtr_UInt3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "UInt3");
			v128.NativeFieldInfoPtr_SInt0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "SInt0");
			v128.NativeFieldInfoPtr_SInt1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "SInt1");
			v128.NativeFieldInfoPtr_SInt2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "SInt2");
			v128.NativeFieldInfoPtr_SInt3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "SInt3");
			v128.NativeFieldInfoPtr_ULong0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "ULong0");
			v128.NativeFieldInfoPtr_ULong1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "ULong1");
			v128.NativeFieldInfoPtr_SLong0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "SLong0");
			v128.NativeFieldInfoPtr_SLong1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "SLong1");
			v128.NativeFieldInfoPtr_Float0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "Float0");
			v128.NativeFieldInfoPtr_Float1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "Float1");
			v128.NativeFieldInfoPtr_Float2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "Float2");
			v128.NativeFieldInfoPtr_Float3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "Float3");
			v128.NativeFieldInfoPtr_Double0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "Double0");
			v128.NativeFieldInfoPtr_Double1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "Double1");
			v128.NativeFieldInfoPtr_Lo64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "Lo64");
			v128.NativeFieldInfoPtr_Hi64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "Hi64");
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00002387 File Offset: 0x00000587
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<v128>.NativeClassPtr, ref this));
		}

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeFieldInfoPtr_Byte0;

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeFieldInfoPtr_Byte1;

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeFieldInfoPtr_Byte2;

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeFieldInfoPtr_Byte3;

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeFieldInfoPtr_Byte4;

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeFieldInfoPtr_Byte5;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeFieldInfoPtr_Byte6;

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeFieldInfoPtr_Byte7;

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeFieldInfoPtr_Byte8;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeFieldInfoPtr_Byte9;

		// Token: 0x0400004C RID: 76
		private static readonly IntPtr NativeFieldInfoPtr_Byte10;

		// Token: 0x0400004D RID: 77
		private static readonly IntPtr NativeFieldInfoPtr_Byte11;

		// Token: 0x0400004E RID: 78
		private static readonly IntPtr NativeFieldInfoPtr_Byte12;

		// Token: 0x0400004F RID: 79
		private static readonly IntPtr NativeFieldInfoPtr_Byte13;

		// Token: 0x04000050 RID: 80
		private static readonly IntPtr NativeFieldInfoPtr_Byte14;

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeFieldInfoPtr_Byte15;

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeFieldInfoPtr_SByte0;

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeFieldInfoPtr_SByte1;

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeFieldInfoPtr_SByte2;

		// Token: 0x04000055 RID: 85
		private static readonly IntPtr NativeFieldInfoPtr_SByte3;

		// Token: 0x04000056 RID: 86
		private static readonly IntPtr NativeFieldInfoPtr_SByte4;

		// Token: 0x04000057 RID: 87
		private static readonly IntPtr NativeFieldInfoPtr_SByte5;

		// Token: 0x04000058 RID: 88
		private static readonly IntPtr NativeFieldInfoPtr_SByte6;

		// Token: 0x04000059 RID: 89
		private static readonly IntPtr NativeFieldInfoPtr_SByte7;

		// Token: 0x0400005A RID: 90
		private static readonly IntPtr NativeFieldInfoPtr_SByte8;

		// Token: 0x0400005B RID: 91
		private static readonly IntPtr NativeFieldInfoPtr_SByte9;

		// Token: 0x0400005C RID: 92
		private static readonly IntPtr NativeFieldInfoPtr_SByte10;

		// Token: 0x0400005D RID: 93
		private static readonly IntPtr NativeFieldInfoPtr_SByte11;

		// Token: 0x0400005E RID: 94
		private static readonly IntPtr NativeFieldInfoPtr_SByte12;

		// Token: 0x0400005F RID: 95
		private static readonly IntPtr NativeFieldInfoPtr_SByte13;

		// Token: 0x04000060 RID: 96
		private static readonly IntPtr NativeFieldInfoPtr_SByte14;

		// Token: 0x04000061 RID: 97
		private static readonly IntPtr NativeFieldInfoPtr_SByte15;

		// Token: 0x04000062 RID: 98
		private static readonly IntPtr NativeFieldInfoPtr_UShort0;

		// Token: 0x04000063 RID: 99
		private static readonly IntPtr NativeFieldInfoPtr_UShort1;

		// Token: 0x04000064 RID: 100
		private static readonly IntPtr NativeFieldInfoPtr_UShort2;

		// Token: 0x04000065 RID: 101
		private static readonly IntPtr NativeFieldInfoPtr_UShort3;

		// Token: 0x04000066 RID: 102
		private static readonly IntPtr NativeFieldInfoPtr_UShort4;

		// Token: 0x04000067 RID: 103
		private static readonly IntPtr NativeFieldInfoPtr_UShort5;

		// Token: 0x04000068 RID: 104
		private static readonly IntPtr NativeFieldInfoPtr_UShort6;

		// Token: 0x04000069 RID: 105
		private static readonly IntPtr NativeFieldInfoPtr_UShort7;

		// Token: 0x0400006A RID: 106
		private static readonly IntPtr NativeFieldInfoPtr_SShort0;

		// Token: 0x0400006B RID: 107
		private static readonly IntPtr NativeFieldInfoPtr_SShort1;

		// Token: 0x0400006C RID: 108
		private static readonly IntPtr NativeFieldInfoPtr_SShort2;

		// Token: 0x0400006D RID: 109
		private static readonly IntPtr NativeFieldInfoPtr_SShort3;

		// Token: 0x0400006E RID: 110
		private static readonly IntPtr NativeFieldInfoPtr_SShort4;

		// Token: 0x0400006F RID: 111
		private static readonly IntPtr NativeFieldInfoPtr_SShort5;

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeFieldInfoPtr_SShort6;

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeFieldInfoPtr_SShort7;

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeFieldInfoPtr_UInt0;

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeFieldInfoPtr_UInt1;

		// Token: 0x04000074 RID: 116
		private static readonly IntPtr NativeFieldInfoPtr_UInt2;

		// Token: 0x04000075 RID: 117
		private static readonly IntPtr NativeFieldInfoPtr_UInt3;

		// Token: 0x04000076 RID: 118
		private static readonly IntPtr NativeFieldInfoPtr_SInt0;

		// Token: 0x04000077 RID: 119
		private static readonly IntPtr NativeFieldInfoPtr_SInt1;

		// Token: 0x04000078 RID: 120
		private static readonly IntPtr NativeFieldInfoPtr_SInt2;

		// Token: 0x04000079 RID: 121
		private static readonly IntPtr NativeFieldInfoPtr_SInt3;

		// Token: 0x0400007A RID: 122
		private static readonly IntPtr NativeFieldInfoPtr_ULong0;

		// Token: 0x0400007B RID: 123
		private static readonly IntPtr NativeFieldInfoPtr_ULong1;

		// Token: 0x0400007C RID: 124
		private static readonly IntPtr NativeFieldInfoPtr_SLong0;

		// Token: 0x0400007D RID: 125
		private static readonly IntPtr NativeFieldInfoPtr_SLong1;

		// Token: 0x0400007E RID: 126
		private static readonly IntPtr NativeFieldInfoPtr_Float0;

		// Token: 0x0400007F RID: 127
		private static readonly IntPtr NativeFieldInfoPtr_Float1;

		// Token: 0x04000080 RID: 128
		private static readonly IntPtr NativeFieldInfoPtr_Float2;

		// Token: 0x04000081 RID: 129
		private static readonly IntPtr NativeFieldInfoPtr_Float3;

		// Token: 0x04000082 RID: 130
		private static readonly IntPtr NativeFieldInfoPtr_Double0;

		// Token: 0x04000083 RID: 131
		private static readonly IntPtr NativeFieldInfoPtr_Double1;

		// Token: 0x04000084 RID: 132
		private static readonly IntPtr NativeFieldInfoPtr_Lo64;

		// Token: 0x04000085 RID: 133
		private static readonly IntPtr NativeFieldInfoPtr_Hi64;

		// Token: 0x04000086 RID: 134
		[FieldOffset(0)]
		public byte Byte0;

		// Token: 0x04000087 RID: 135
		[FieldOffset(1)]
		public byte Byte1;

		// Token: 0x04000088 RID: 136
		[FieldOffset(2)]
		public byte Byte2;

		// Token: 0x04000089 RID: 137
		[FieldOffset(3)]
		public byte Byte3;

		// Token: 0x0400008A RID: 138
		[FieldOffset(4)]
		public byte Byte4;

		// Token: 0x0400008B RID: 139
		[FieldOffset(5)]
		public byte Byte5;

		// Token: 0x0400008C RID: 140
		[FieldOffset(6)]
		public byte Byte6;

		// Token: 0x0400008D RID: 141
		[FieldOffset(7)]
		public byte Byte7;

		// Token: 0x0400008E RID: 142
		[FieldOffset(8)]
		public byte Byte8;

		// Token: 0x0400008F RID: 143
		[FieldOffset(9)]
		public byte Byte9;

		// Token: 0x04000090 RID: 144
		[FieldOffset(10)]
		public byte Byte10;

		// Token: 0x04000091 RID: 145
		[FieldOffset(11)]
		public byte Byte11;

		// Token: 0x04000092 RID: 146
		[FieldOffset(12)]
		public byte Byte12;

		// Token: 0x04000093 RID: 147
		[FieldOffset(13)]
		public byte Byte13;

		// Token: 0x04000094 RID: 148
		[FieldOffset(14)]
		public byte Byte14;

		// Token: 0x04000095 RID: 149
		[FieldOffset(15)]
		public byte Byte15;

		// Token: 0x04000096 RID: 150
		[FieldOffset(0)]
		public sbyte SByte0;

		// Token: 0x04000097 RID: 151
		[FieldOffset(1)]
		public sbyte SByte1;

		// Token: 0x04000098 RID: 152
		[FieldOffset(2)]
		public sbyte SByte2;

		// Token: 0x04000099 RID: 153
		[FieldOffset(3)]
		public sbyte SByte3;

		// Token: 0x0400009A RID: 154
		[FieldOffset(4)]
		public sbyte SByte4;

		// Token: 0x0400009B RID: 155
		[FieldOffset(5)]
		public sbyte SByte5;

		// Token: 0x0400009C RID: 156
		[FieldOffset(6)]
		public sbyte SByte6;

		// Token: 0x0400009D RID: 157
		[FieldOffset(7)]
		public sbyte SByte7;

		// Token: 0x0400009E RID: 158
		[FieldOffset(8)]
		public sbyte SByte8;

		// Token: 0x0400009F RID: 159
		[FieldOffset(9)]
		public sbyte SByte9;

		// Token: 0x040000A0 RID: 160
		[FieldOffset(10)]
		public sbyte SByte10;

		// Token: 0x040000A1 RID: 161
		[FieldOffset(11)]
		public sbyte SByte11;

		// Token: 0x040000A2 RID: 162
		[FieldOffset(12)]
		public sbyte SByte12;

		// Token: 0x040000A3 RID: 163
		[FieldOffset(13)]
		public sbyte SByte13;

		// Token: 0x040000A4 RID: 164
		[FieldOffset(14)]
		public sbyte SByte14;

		// Token: 0x040000A5 RID: 165
		[FieldOffset(15)]
		public sbyte SByte15;

		// Token: 0x040000A6 RID: 166
		[FieldOffset(0)]
		public ushort UShort0;

		// Token: 0x040000A7 RID: 167
		[FieldOffset(2)]
		public ushort UShort1;

		// Token: 0x040000A8 RID: 168
		[FieldOffset(4)]
		public ushort UShort2;

		// Token: 0x040000A9 RID: 169
		[FieldOffset(6)]
		public ushort UShort3;

		// Token: 0x040000AA RID: 170
		[FieldOffset(8)]
		public ushort UShort4;

		// Token: 0x040000AB RID: 171
		[FieldOffset(10)]
		public ushort UShort5;

		// Token: 0x040000AC RID: 172
		[FieldOffset(12)]
		public ushort UShort6;

		// Token: 0x040000AD RID: 173
		[FieldOffset(14)]
		public ushort UShort7;

		// Token: 0x040000AE RID: 174
		[FieldOffset(0)]
		public short SShort0;

		// Token: 0x040000AF RID: 175
		[FieldOffset(2)]
		public short SShort1;

		// Token: 0x040000B0 RID: 176
		[FieldOffset(4)]
		public short SShort2;

		// Token: 0x040000B1 RID: 177
		[FieldOffset(6)]
		public short SShort3;

		// Token: 0x040000B2 RID: 178
		[FieldOffset(8)]
		public short SShort4;

		// Token: 0x040000B3 RID: 179
		[FieldOffset(10)]
		public short SShort5;

		// Token: 0x040000B4 RID: 180
		[FieldOffset(12)]
		public short SShort6;

		// Token: 0x040000B5 RID: 181
		[FieldOffset(14)]
		public short SShort7;

		// Token: 0x040000B6 RID: 182
		[FieldOffset(0)]
		public uint UInt0;

		// Token: 0x040000B7 RID: 183
		[FieldOffset(4)]
		public uint UInt1;

		// Token: 0x040000B8 RID: 184
		[FieldOffset(8)]
		public uint UInt2;

		// Token: 0x040000B9 RID: 185
		[FieldOffset(12)]
		public uint UInt3;

		// Token: 0x040000BA RID: 186
		[FieldOffset(0)]
		public int SInt0;

		// Token: 0x040000BB RID: 187
		[FieldOffset(4)]
		public int SInt1;

		// Token: 0x040000BC RID: 188
		[FieldOffset(8)]
		public int SInt2;

		// Token: 0x040000BD RID: 189
		[FieldOffset(12)]
		public int SInt3;

		// Token: 0x040000BE RID: 190
		[FieldOffset(0)]
		public ulong ULong0;

		// Token: 0x040000BF RID: 191
		[FieldOffset(8)]
		public ulong ULong1;

		// Token: 0x040000C0 RID: 192
		[FieldOffset(0)]
		public long SLong0;

		// Token: 0x040000C1 RID: 193
		[FieldOffset(8)]
		public long SLong1;

		// Token: 0x040000C2 RID: 194
		[FieldOffset(0)]
		public float Float0;

		// Token: 0x040000C3 RID: 195
		[FieldOffset(4)]
		public float Float1;

		// Token: 0x040000C4 RID: 196
		[FieldOffset(8)]
		public float Float2;

		// Token: 0x040000C5 RID: 197
		[FieldOffset(12)]
		public float Float3;

		// Token: 0x040000C6 RID: 198
		[FieldOffset(0)]
		public double Double0;

		// Token: 0x040000C7 RID: 199
		[FieldOffset(8)]
		public double Double1;

		// Token: 0x040000C8 RID: 200
		[FieldOffset(0)]
		public v64 Lo64;

		// Token: 0x040000C9 RID: 201
		[FieldOffset(8)]
		public v64 Hi64;
	}
}
