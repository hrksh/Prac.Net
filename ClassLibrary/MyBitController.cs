namespace ClassLibrary;

public class MyBitController
{
    private string _binary = string.Empty;
    public string Binary => this._binary;
    private int _input = 0;
    public int Input => this._input;

    private const int _maxbit = 32;

    private MyBitController() {}

    public MyBitController(int num)
    {
        this._input = num;
        this._binary = ToBin32((uint)num);
        this.ShowCurrentNumber();
        this.ShowBinaryString();
    }

    public void ShowCurrentNumber() => Console.WriteLine($"input:  {this._input}");
    public void ShowBinaryString() => Console.WriteLine($"binary: {this._binary}");

    public static string ToBin32(uint v) => Convert.ToString(v, 2).PadLeft(_maxbit, '0');
    public static string ToBin(uint v, int width) => Convert.ToString(v, 2).PadLeft(width, '0');

    public static int FromBin(string binary) => Convert.ToInt32(binary, 2);

    public bool VerifyBit(int target, int startbit, int bitLength)
    {
        // --- Guard ---
        if (startbit < 0 || bitLength <= 0 || startbit >= _maxbit) 
            throw new ArgumentOutOfRangeException(nameof(startbit), "startbitは0〜31");
        if (bitLength > _maxbit) 
            throw new ArgumentOutOfRangeException(nameof(bitLength), "bitLengthは1〜32");
        if (startbit + bitLength > _maxbit) 
            Console.WriteLine($"[warn] 範囲が32ビットを跨ぎます: start={startbit}, len={bitLength}");

        uint u = unchecked((uint)target);

        // 論理右シフト（intの算術右シフトを避ける）
        uint shifted = u >> startbit;

        // 32ビット対応のマスク
        uint mask = (bitLength == 32) ? 0xFFFF_FFFFu : ((1u << bitLength) - 1u);

        uint extracted = shifted & mask;
        bool anySet = extracted != 0;

        Console.WriteLine($"target : {ToBin32(u)}");
        Console.WriteLine($"shift  : {ToBin32(shifted)}  (>> {startbit})");
        Console.WriteLine($"mask   : {ToBin(mask, bitLength)}  (len={bitLength})");
        Console.WriteLine($"select : {ToBin(extracted, bitLength)}  => {(anySet ? "true" : "false")}");

        return anySet;
    }
}
