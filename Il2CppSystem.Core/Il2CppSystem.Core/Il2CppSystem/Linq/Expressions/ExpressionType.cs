using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Linq.Expressions
{
	// Token: 0x02000016 RID: 22
	[OriginalName("System.Core.dll", "System.Linq.Expressions", "ExpressionType")]
	public enum ExpressionType
	{
		// Token: 0x040000A9 RID: 169
		Add,
		// Token: 0x040000AA RID: 170
		AddChecked,
		// Token: 0x040000AB RID: 171
		And,
		// Token: 0x040000AC RID: 172
		AndAlso,
		// Token: 0x040000AD RID: 173
		ArrayLength,
		// Token: 0x040000AE RID: 174
		ArrayIndex,
		// Token: 0x040000AF RID: 175
		Call,
		// Token: 0x040000B0 RID: 176
		Coalesce,
		// Token: 0x040000B1 RID: 177
		Conditional,
		// Token: 0x040000B2 RID: 178
		Constant,
		// Token: 0x040000B3 RID: 179
		Convert,
		// Token: 0x040000B4 RID: 180
		ConvertChecked,
		// Token: 0x040000B5 RID: 181
		Divide,
		// Token: 0x040000B6 RID: 182
		Equal,
		// Token: 0x040000B7 RID: 183
		ExclusiveOr,
		// Token: 0x040000B8 RID: 184
		GreaterThan,
		// Token: 0x040000B9 RID: 185
		GreaterThanOrEqual,
		// Token: 0x040000BA RID: 186
		Invoke,
		// Token: 0x040000BB RID: 187
		Lambda,
		// Token: 0x040000BC RID: 188
		LeftShift,
		// Token: 0x040000BD RID: 189
		LessThan,
		// Token: 0x040000BE RID: 190
		LessThanOrEqual,
		// Token: 0x040000BF RID: 191
		ListInit,
		// Token: 0x040000C0 RID: 192
		MemberAccess,
		// Token: 0x040000C1 RID: 193
		MemberInit,
		// Token: 0x040000C2 RID: 194
		Modulo,
		// Token: 0x040000C3 RID: 195
		Multiply,
		// Token: 0x040000C4 RID: 196
		MultiplyChecked,
		// Token: 0x040000C5 RID: 197
		Negate,
		// Token: 0x040000C6 RID: 198
		UnaryPlus,
		// Token: 0x040000C7 RID: 199
		NegateChecked,
		// Token: 0x040000C8 RID: 200
		New,
		// Token: 0x040000C9 RID: 201
		NewArrayInit,
		// Token: 0x040000CA RID: 202
		NewArrayBounds,
		// Token: 0x040000CB RID: 203
		Not,
		// Token: 0x040000CC RID: 204
		NotEqual,
		// Token: 0x040000CD RID: 205
		Or,
		// Token: 0x040000CE RID: 206
		OrElse,
		// Token: 0x040000CF RID: 207
		Parameter,
		// Token: 0x040000D0 RID: 208
		Power,
		// Token: 0x040000D1 RID: 209
		Quote,
		// Token: 0x040000D2 RID: 210
		RightShift,
		// Token: 0x040000D3 RID: 211
		Subtract,
		// Token: 0x040000D4 RID: 212
		SubtractChecked,
		// Token: 0x040000D5 RID: 213
		TypeAs,
		// Token: 0x040000D6 RID: 214
		TypeIs,
		// Token: 0x040000D7 RID: 215
		Assign,
		// Token: 0x040000D8 RID: 216
		Block,
		// Token: 0x040000D9 RID: 217
		DebugInfo,
		// Token: 0x040000DA RID: 218
		Decrement,
		// Token: 0x040000DB RID: 219
		Dynamic,
		// Token: 0x040000DC RID: 220
		Default,
		// Token: 0x040000DD RID: 221
		Extension,
		// Token: 0x040000DE RID: 222
		Goto,
		// Token: 0x040000DF RID: 223
		Increment,
		// Token: 0x040000E0 RID: 224
		Index,
		// Token: 0x040000E1 RID: 225
		Label,
		// Token: 0x040000E2 RID: 226
		RuntimeVariables,
		// Token: 0x040000E3 RID: 227
		Loop,
		// Token: 0x040000E4 RID: 228
		Switch,
		// Token: 0x040000E5 RID: 229
		Throw,
		// Token: 0x040000E6 RID: 230
		Try,
		// Token: 0x040000E7 RID: 231
		Unbox,
		// Token: 0x040000E8 RID: 232
		AddAssign,
		// Token: 0x040000E9 RID: 233
		AndAssign,
		// Token: 0x040000EA RID: 234
		DivideAssign,
		// Token: 0x040000EB RID: 235
		ExclusiveOrAssign,
		// Token: 0x040000EC RID: 236
		LeftShiftAssign,
		// Token: 0x040000ED RID: 237
		ModuloAssign,
		// Token: 0x040000EE RID: 238
		MultiplyAssign,
		// Token: 0x040000EF RID: 239
		OrAssign,
		// Token: 0x040000F0 RID: 240
		PowerAssign,
		// Token: 0x040000F1 RID: 241
		RightShiftAssign,
		// Token: 0x040000F2 RID: 242
		SubtractAssign,
		// Token: 0x040000F3 RID: 243
		AddAssignChecked,
		// Token: 0x040000F4 RID: 244
		MultiplyAssignChecked,
		// Token: 0x040000F5 RID: 245
		SubtractAssignChecked,
		// Token: 0x040000F6 RID: 246
		PreIncrementAssign,
		// Token: 0x040000F7 RID: 247
		PreDecrementAssign,
		// Token: 0x040000F8 RID: 248
		PostIncrementAssign,
		// Token: 0x040000F9 RID: 249
		PostDecrementAssign,
		// Token: 0x040000FA RID: 250
		TypeEqual,
		// Token: 0x040000FB RID: 251
		OnesComplement,
		// Token: 0x040000FC RID: 252
		IsTrue,
		// Token: 0x040000FD RID: 253
		IsFalse
	}
}
